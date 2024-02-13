using EPLE.IO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EPLE.Core;
using EPLE.IO;
using TwinCAT.Ads;
using log4net;
using log4net.Config;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using TwinCAT.TypeSystem;

namespace Device.Beckhoff
{
    public class TwinCAT : IDeviceHandler
    {
        private Task tcTask;
        public eDevMode DevMode { get; set; }

        public bool DeviceAttach(string arguments)
        {
            bool ret = false;
            TwinCATConnector.ConfigFilePath = arguments;

            switch (TwinCATConnector.tcConnect())
            {
                case tcFunctionResult.TC_SUCCESS:
                    if (TwinCATConnector.tcCreateHandle() == tcFunctionResult.TC_SUCCESS)
                    {
                        DevMode = eDevMode.CONNECT;
                        ret = true;
                    }
                    else
                    {
                        DevMode = eDevMode.DISCONNECT;
                        ret = false;
                    }
                    break;
                case tcFunctionResult.TC_FAIL_TO_LOAD_PLC_CONFIG:
                    DevMode = eDevMode.ERROR;
                    ret = false;
                    break;
                case tcFunctionResult.TC_FAIL_TO_CONNECT_DEVICE:
                    DevMode = eDevMode.ERROR;
                    ret = false;
                    break;
            }

            if (ret)
            {
                tcTask = Task.Run(() =>
                {
                    while (true)
                    {
                        if (DevMode == eDevMode.CONNECT)
                        {
                            TwinCATConnector.tcReadAll();
                            TwinCATConnector.tcUpdateAxStatus();

                            Thread.Sleep(100);
                        }
                    }
                });
            }

            return ret;
        }

        public bool DeviceDettach()
        {
            tcTask.Wait();

            if (tcTask.IsCompleted)
                TwinCATConnector.tcDispose();

            return true;
        }

        public bool DeviceInit()
        {
            bool ret = false;

            switch (TwinCATConnector.tcConnect())
            {
                case tcFunctionResult.TC_SUCCESS:
                    if (TwinCATConnector.tcCreateHandle() == tcFunctionResult.TC_SUCCESS)
                    {
                        DevMode = eDevMode.CONNECT;
                        ret = true;
                    }
                    else
                    {
                        DevMode = eDevMode.DISCONNECT;
                        ret = false;
                    }
                    break;
                case tcFunctionResult.TC_FAIL_TO_LOAD_PLC_CONFIG:
                    DevMode = eDevMode.ERROR;
                    ret = false;
                    break;
                case tcFunctionResult.TC_FAIL_TO_CONNECT_DEVICE:
                    DevMode = eDevMode.ERROR;
                    ret = false;
                    break;
            }

            return ret;
        }

        public bool DeviceReset()
        {
            if (tcTask.Wait(100))
            {
                TwinCATConnector.tcDispose();
            }

            return DeviceInit();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_1">index</param>
        /// <param name="id_2">size</param>
        /// <param name="id_3">offset</param>
        /// <param name="id_4">subindex</param>
        /// <param name="result">data vaildation result</param>
        /// <returns>input object data</returns>
        public object GET_DATA_IN(string id_1, string id_2, string id_3, string id_4, ref bool result)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_1">index</param>
        /// <param name="id_2">size</param>
        /// <param name="id_3">offset</param>
        /// <param name="id_4">subindex</param>
        /// <param name="result">data vaildation result</param>
        /// <returns>input double(64-bit) data</returns>
        public double GET_DOUBLE_IN(string id_1, string id_2, string id_3, string id_4, ref bool result)
        {
            double returnValue = 0;
            result = false;
                int index = int.Parse(id_1);

            if (!TwinCATConnector.IsConnected)
                return returnValue;

            if (index == (int)epInOut.P_IN || index == (int)epInOut.T_IN)
            {
                int size = int.Parse(id_2);
                int offset = int.Parse(id_3);
                int subIndex = int.Parse(id_4);

                // BYTE TYPE
                if (size == 4)
                {
                    returnValue = Convert.ToSingle(TwinCATConnector.tcGetData(tcDataType.REAL, index, offset));
                    result = true;
                }
                else if (size == 8)
                {
                    returnValue = Convert.ToSingle(TwinCATConnector.tcGetData(tcDataType.LREAL, index, offset));
                    result = true;
                }
                else
                {
                    return returnValue;
                }
            }
            else if (index == (int)epInOut.M_IN)
            {
                int size = int.Parse(id_2);
                int axis = int.Parse(id_3);
                int param = int.Parse(id_4);

                if (size == 8)
                {
                    switch(param)
                    {
                        case (int)tcAxisFeedbackParam.ActPos:
                            returnValue = TwinCATConnector.tcAxFeedback[axis].actualPosition;
                            result = true;
                            break;
                        case (int)tcAxisFeedbackParam.ActVel:
                            returnValue = TwinCATConnector.tcAxFeedback[axis].actualVelocity;
                            result = true;
                            break;
                        case (int)tcAxisFeedbackParam.SetPos:
                            returnValue = TwinCATConnector.tcAxFeedback[axis].setPosition;
                            result = true;
                            break;
                        case (int)tcAxisFeedbackParam.SetVel:
                            returnValue = TwinCATConnector.tcAxFeedback[axis].setVelocity;
                            result = true;
                            break;
                        case (int)tcAxisFeedbackParam.ControlOverride:
                            returnValue = TwinCATConnector.tcAxFeedback[axis].controlleroverride;
                            result = true;
                            break;
                    }
                }
            }

            return returnValue;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_1">index</param>
        /// <param name="id_2">size</param>
        /// <param name="id_3">offset</param>
        /// <param name="id_4">subindex</param>
        /// <param name="result">data vaildation result</param>
        /// <returns>input integer(8 ~ 32 bit) data</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GET_INT_IN(string id_1, string id_2, string id_3, string id_4, ref bool result)
        {
            int returnValue = 0;
            result = false;
            int index = int.Parse(id_1);

            if (!TwinCATConnector.IsConnected)
                return returnValue;

            if (index == (int)epInOut.P_IN || index == (int)epInOut.ALARM || index == (int)epInOut.T_IN)
            {
                int size = int.Parse(id_2);
                int offset = int.Parse(id_3);

                // BYTE TYPE
                if (size == 1)
                {
                    returnValue = Convert.ToInt32(TwinCATConnector.tcGetData(tcDataType.BYTE, index, offset));
                    result = true;
                }
                else if (size == 2)
                {
                    returnValue = Convert.ToInt32(TwinCATConnector.tcGetData(tcDataType.INT16, index, offset));
                    result = true;
                }
                else if (size == 4)
                {
                    returnValue = Convert.ToInt32(TwinCATConnector.tcGetData(tcDataType.INT32, index, offset));
                    result = true;
                }
                else
                {
                    return returnValue;
                }
            }
            else if (index == (int)epInOut.M_IN)
            {
                int size = int.Parse(id_2);
                int axis = int.Parse(id_3);
                int param = int.Parse(id_4);

                switch (param)
                {
                    case (int)tcAxisFeedbackParam.ErrorId:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].ErrorId);
                        break;
                    case (int)tcAxisFeedbackParam.HasError:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].hasError);
                        break;
                    case (int)tcAxisFeedbackParam.IsReady:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isReady);
                        break;
                    case (int)tcAxisFeedbackParam.IsDisabled:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isDisabled);
                        break;
                    case (int)tcAxisFeedbackParam.IsFwDisabled:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isFwDisabled);
                        break;
                    case (int)tcAxisFeedbackParam.IsBwDisabled:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isBwDisabled);
                        break;
                    case (int)tcAxisFeedbackParam.IsCalibrated:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isCalibrated);
                        break;
                    case (int)tcAxisFeedbackParam.HasJob:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].hasJob);
                        break;
                    case (int)tcAxisFeedbackParam.IsNotMove:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isNotMoving);
                        break;
                    case (int)tcAxisFeedbackParam.IsPositive:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isPositiveDirection);
                        break;
                    case (int)tcAxisFeedbackParam.IsNegative:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isNegativeDirection);
                        break;
                    case (int)tcAxisFeedbackParam.IsInTarget:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isInTarget);
                        break;
                    case (int)tcAxisFeedbackParam.IsInRange:
                        returnValue = Convert.ToInt32(TwinCATConnector.tcAxFeedback[axis].isInRange);
                        break;
                }
            }

            return returnValue;
        }

        public string GET_STRING_IN(string id_1, string id_2, string id_3, string id_4, ref bool result)
        {
            string returnValue = string.Empty;
            result = false;

            if (!id_1.Equals("1"))
            {
                return returnValue;
            }

            int index = int.Parse(id_1);
            int size = int.Parse(id_2);
            int offset = int.Parse(id_3);

            if (TwinCATConnector.IsConnected)
            {
                returnValue = TwinCATConnector.tcGetData(tcDataType.STRING_32, index, offset).ToString();
                result = true;
            }
            else
            { 
                return returnValue; 
            }

            return returnValue;
        }

        public eDevMode IsDevMode()
        {
            return DevMode;
        }

        public void SET_DATA_OUT(string id_1, string id_2, string id_3, string id_4, object value, ref bool result)
        {
            throw new NotImplementedException();
        }

        public void SET_DOUBLE_OUT(string id_1, string id_2, string id_3, string id_4, double value, ref bool result)
        {
            result = false;

            int index = int.Parse(id_1);


            if (!TwinCATConnector.IsConnected)
                return;

            if (index == (int)epInOut.P_OUT || index == (int)epInOut.T_OUT)
            {
                int size = int.Parse(id_2);
                int offset = int.Parse(id_3);

                if (index == (int)epInOut.T_OUT)
                    index = 3;

                TwinCATConnector.tcSetData(tcDataType.REAL, index, offset, value);
                result = true;
            }
            else if (index == (int)epInOut.M_OUT)
            {
                int axis = int.Parse(id_3);
                int param = int .Parse(id_4);


                switch (param)
                {
                    case (int)tcAxisControlParam.TargetPos:
                        TwinCATConnector.tcAxCommand[axis].TARGET_POSITION = value;
                        break;
                    case (int)tcAxisControlParam.TargetVel:
                        TwinCATConnector.tcAxCommand[axis].TARGET_VELOCITY = value;
                        break;
                    case (int)tcAxisControlParam.TargetAcc:
                        TwinCATConnector.tcAxCommand[axis].TARGET_ACCELERATION = value;
                        break;
                    case (int)tcAxisControlParam.TargetDcc:
                        TwinCATConnector.tcAxCommand[axis].TARGET_DECELERATION = value;
                        break;
                    case (int)tcAxisControlParam.TargetJerk:
                        TwinCATConnector.tcAxCommand[axis].TARGET_JERK = value;
                        break;
                    case (int)tcAxisControlParam.ControlOverride:
                        TwinCATConnector.tcAxCommand[axis].CONTROLLER_OVERRIDE = value;
                        break;
                }

                TwinCATConnector.tcSetAxisCommand(axis);
            }
        }

        public void SET_INT_OUT(string id_1, string id_2, string id_3, string id_4, int value, ref bool result)
        {
            result = false;

            int index = int.Parse(id_1);


            if (!TwinCATConnector.IsConnected)
                return;

            if (index == (int)epInOut.P_OUT || index == (int)epInOut.T_OUT)
            {
                int size = int.Parse(id_2);
                int offset = int.Parse(id_3);

                if (index == (int)epInOut.T_OUT)
                    index = 3;

                TwinCATConnector.tcSetData(tcDataType.BYTE, index, offset, value);
                result = true;
            } 
            else if (index == (int)epInOut.M_OUT)
            {
                int size = int.Parse(id_2);
                int axis = int.Parse(id_3);
                int param = int.Parse(id_4);

                switch ((tcAxisControlParam)param)
                {
                    case tcAxisControlParam.JogBwFast:
                        TwinCATConnector.tcAxCommand[axis].SERVO_JOG_BW_FAST = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.JogFwFast:
                        TwinCATConnector.tcAxCommand[axis].SERVO_JOG_FW_FAST = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.JogBwSlow:
                        TwinCATConnector.tcAxCommand[axis].SERVO_JOG_BW_SLOW = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.JogFwSlow:
                        TwinCATConnector.tcAxCommand[axis].SERVO_JOG_FW_SLOW = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoMoveAbs:
                        TwinCATConnector.tcAxCommand[axis].SERVO_MOVE_ABS = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoMoveRel:
                        TwinCATConnector.tcAxCommand[axis].SERVO_MOVE_REL = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoHalt:
                        TwinCATConnector.tcAxCommand[axis].SERVO_HALT = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoHome:
                        TwinCATConnector.tcAxCommand[axis].SERVO_HOME = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.JogMode:
                        TwinCATConnector.tcAxCommand[axis].SERVO_JOG_MODE = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoDisable:
                        TwinCATConnector.tcAxCommand[axis].SERVO_OFF = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoEnable:
                        TwinCATConnector.tcAxCommand[axis].SERVO_ON = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoBwOn:
                        TwinCATConnector.tcAxCommand[axis].SERVO_ON_BW = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoFwOn:
                        TwinCATConnector.tcAxCommand[axis].SERVO_ON_FW = Convert.ToBoolean(value);
                        break;
                    case tcAxisControlParam.ServoReset:
                        TwinCATConnector.tcAxCommand[axis].SERVO_RESET = Convert.ToBoolean(value);
                        break;
                }

                if (TwinCATConnector.IsConnected && TwinCATConnector.tcSetAxisCommand(axis) == tcFunctionResult.TC_SUCCESS) result = true; 
                else result = false;
            }
        }

        public void SET_STRING_OUT(string id_1, string id_2, string id_3, string id_4, string value, ref bool result)
        {
            throw new NotImplementedException();
        }

        private int Offset(string id, int zeroOffset) 
        {
            if (id.Equals("0")) zeroOffset += 0;
            else if (id.Equals("1")) zeroOffset += 1;
            else if (id.Equals("2")) zeroOffset += 2;
            else if (id.Equals("3")) zeroOffset += 3;
            else if (id.Equals("4")) zeroOffset += 4;
            else if (id.Equals("5")) zeroOffset += 5;
            else if (id.Equals("6")) zeroOffset += 6;
            else if (id.Equals("7")) zeroOffset += 7;
            else if (id.Equals("8")) zeroOffset += 8;
            else if (id.Equals("9")) zeroOffset += 9;
            else if (id.Equals("A")) zeroOffset += 10;
            else if (id.Equals("B")) zeroOffset += 11;
            else if (id.Equals("C")) zeroOffset += 12;
            else if (id.Equals("D")) zeroOffset += 13;
            else if (id.Equals("E")) zeroOffset += 14;
            else if (id.Equals("F")) zeroOffset += 15;

            return zeroOffset;
        }


    }
}
