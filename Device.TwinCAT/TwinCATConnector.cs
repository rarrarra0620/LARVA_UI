using EPLE.Core;
using EPLE.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TwinCAT.Ads;



namespace Device.Beckhoff
{
    class TwinCATConnector
    {
        #region internal use
        private static XDocument tcConnectorConfig;
        private static XDocument tcDataConfig;
        private static TcAdsClient tcClient = new TcAdsClient();
        private static List<tcPlcVar> tcVarList = new List<tcPlcVar>();
        private static Dictionary<string, tcDataVar> tcDataList = new Dictionary<string, tcDataVar>();
        private static tcFunctionResult tcError;

        private static short Axis_MaxAxes = 0;

        public static _Axis_PlcToHmi[] tcAxFeedback;
        public static _Axis_HmiToPlc[] tcAxCommand;
        public static _Axis_PlcToHmi[] tcAxStatus;
        private static string tcConfigPath;
        #endregion

        #region Connector Properties
        public static string ConfigFilePath { get { return tcConfigPath; } set { tcConfigPath = value; } }

        public static bool IsConnected
        {
            get { return tcClient.IsConnected; }
        }
        public static int Count
        {
            get { return tcVarList.Count; }
        }
        public static int Axis_Count
        {
            get { return (int)Axis_MaxAxes; }
        }
        public static string GetError
        {
            get
            {
                switch (tcError)
                {
                    case tcFunctionResult.TC_FAIL_TO_CONNECT_DEVICE:
                        return "Error - Failed to connect to remote device. Check that AMS Net ID and Port is correct. Ensure that the route is also correctly added.";
                    case tcFunctionResult.TC_FAIL_TO_LOAD_PLC_CONFIG:
                        return "Error - Failed find connector configuration file.";
                    case tcFunctionResult.TC_NOT_CONNECTED:
                        return "Error - Device not connected yet.";
                    default:
                        return "No error";
                }
            }
        }
        #endregion

        #region Connects to target device, defaults to local
        public static tcFunctionResult tcConnect()
        {
            try
            {
                tcConnectorConfig = XDocument.Load(tcConfigPath);
            }
            catch (Exception ex)
            {
                return tcFunctionResult.TC_FAIL_TO_LOAD_PLC_CONFIG;
            }
            XElement tcPLC = tcConnectorConfig.Root;//("Plc");
            tcClient = new TcAdsClient();
            try
            {
                tcClient.Connect(tcPLC.Attribute("AmsNetId").Value, int.Parse(tcPLC.Attribute("AmsPort").Value));
            }
            catch (Exception ex)
            {
                return tcFunctionResult.TC_FAIL_TO_CONNECT_DEVICE;
            }

            return tcFunctionResult.TC_SUCCESS;
        }
        #endregion

        #region Adds a TwinCAT varible handle to the cache
        public static tcFunctionResult tcCreateHandle()
        {
            if (!tcClient.IsConnected) return tcFunctionResult.TC_NOT_CONNECTED;

            bool _io_ok = false, _axis_ok = false;

            #region Creating PLC IO handles
            IEnumerable<XElement> PlcVars = tcConnectorConfig.Root.Elements("PlcVar");
            foreach (XElement PlcVar in PlcVars)
            {
                tcPlcVar PlcVarBuffer = new tcPlcVar();
                try
                {
                    PlcVarBuffer.Handle = tcClient.CreateVariableHandle(PlcVar.Attribute("Name").Value);
                    if (PlcVarBuffer.Handle == 0) return tcFunctionResult.TC_FAIL_TO_CREATE_HANDLE;
                    PlcVarBuffer.Name = PlcVar.Attribute("Name").Value;
                    PlcVarBuffer.Type = PlcVar.Attribute("Type").Value;
                    PlcVarBuffer.Size = int.Parse(PlcVar.Attribute("Size").Value?? "1");
                    PlcVarBuffer.Count = int.Parse(PlcVar.Attribute("Count").Value?? "0");
                    PlcVarBuffer.Data = new object();
                    PlcVarBuffer.Tag = PlcVar.Attribute("Tag").Value;
                    PlcVarBuffer.Index = int.Parse(PlcVar.Attribute("Index").Value);
                    tcVarList.Add(PlcVarBuffer);
                    _io_ok = true;
                }
                catch (Exception ex)
                {
                    LogHelper.Instance.ErrorLog.Error(ex.ToString());
                }
            }
            #endregion

            #region Creating PLC Axis handles
            XElement AxsVar = tcConnectorConfig.Root.Element("AxsVar");
            if (AxsVar == null)
            {
                Axis_MaxAxes = 0;
            }
            else
            {
                try
                {
                    int AxCount = tcClient.CreateVariableHandle(AxsVar.Attribute("Count").Value);
                    Axis_MaxAxes = (short)tcClient.ReadAny(AxCount, typeof(short));
                    tcClient.DeleteVariableHandle(AxCount);
                    tcAxFeedback = new _Axis_PlcToHmi[Axis_MaxAxes];
                    tcAxCommand = new _Axis_HmiToPlc[Axis_MaxAxes];
                    for (int k = 0; k < Axis_MaxAxes; k++)
                    {
                        tcAxFeedback[k] = new _Axis_PlcToHmi();
                        tcAxFeedback[k].handle = tcClient.CreateVariableHandle(AxsVar.Attribute("PlcToHmi").Value + "[" + (k + 1).ToString() + "]");
                        tcAxFeedback[k].size = short.Parse(AxsVar.Attribute("P2HSize").Value);
                        tcAxCommand[k] = new _Axis_HmiToPlc();
                        tcAxCommand[k].handle = tcClient.CreateVariableHandle(AxsVar.Attribute("HmiToPlc").Value + "[" + (k + 1).ToString() + "]");
                        tcAxCommand[k].size = short.Parse(AxsVar.Attribute("H2PSize").Value);
                    }
                    _axis_ok = true;
                }
                catch (Exception ex)
                {

                }
            }
            #endregion

            if (_io_ok && _axis_ok)
            {
                return tcFunctionResult.TC_SUCCESS;
            }
            else
            {
                return tcFunctionResult.TC_SUCCESS;
            }
        }
        #endregion

        #region Read all data in cache
        public static tcFunctionResult tcReadAll()
        {
            if (!tcClient.IsConnected) return tcFunctionResult.TC_NOT_CONNECTED;
            for (int i = 0; i < tcVarList.Count; i++)
            {
                AdsStream tcDataStream = new AdsStream(tcVarList[i].Size);
                AdsBinaryReader tcStreamReader = new AdsBinaryReader(tcDataStream);
                try
                {
                    tcClient.Read(tcVarList[i].Handle, tcDataStream);
                }
                catch (Exception ex)
                {
                    return tcFunctionResult.TC_FAIL_TO_READ_DATA;
                }
                tcPlcVar buffer = tcVarList[i];
                switch (tcVarList[i].Type.ToLower())
                {
                    case "bool":
                    case "arbool":
                        bool[] boolBuffer = new bool[buffer.Count];
                        BitArray ba = new BitArray(tcStreamReader.ReadBytes(buffer.Size));
                        ba.CopyTo(boolBuffer, 0);
                        buffer.Data = (object)boolBuffer;
                        break;
                    case "int":
                        buffer.Data = tcStreamReader.ReadInt16();
                        break;
                    case "arint":
                        short[] shortBuffer = new short[buffer.Count];
                        for (int j = 0; j < shortBuffer.Length; j++)
                        {
                            shortBuffer[j] = tcStreamReader.ReadInt16();
                        }
                        buffer.Data = (object)shortBuffer;
                        break;
                    case "string":
                        buffer.Data = tcStreamReader.ReadPlcString(255);
                        break;
                    case "real":
                        buffer.Data = tcStreamReader.ReadSingle();
                        break;
                    case "lreal":
                        buffer.Data = tcStreamReader.ReadDouble();
                        break;
                    case "byte":
                        buffer.Data = tcStreamReader.ReadBytes(buffer.Size);
                        break;
                }
                tcVarList[i] = buffer;
                tcStreamReader.Close();
            }
            return tcFunctionResult.TC_SUCCESS;
        }
        #endregion

        #region Write data to PLC
        public static tcFunctionResult tcWriteData(int index, int offset, int length, object data)
        {
            if (!tcClient.IsConnected)
            {
                return tcFunctionResult.TC_NOT_CONNECTED;
            }
            if (index > tcVarList.Count || index < 0)
            {
                return tcFunctionResult.TC_VARLIST_OUTOFBOUND;
            }

            AdsStream _DataStrem = new AdsStream(tcVarList[index].Size);
            AdsBinaryWriter tcStreamWriter = new AdsBinaryWriter(_DataStrem);

            try
            {
                switch (tcVarList[index].Type.ToLower())
                {
                    case "bool":
                        byte[] byteArray = new byte[tcVarList[index].Size];
                        BitArray ba = new BitArray((byte[])tcVarList[index].Data);
                        ba[offset] = (bool)data;
                        ba.CopyTo(byteArray, 0);
                        tcStreamWriter.Write(byteArray);
                        tcClient.Write(tcVarList[index].Handle, _DataStrem);
                        break;
                    case "byte":
                        _DataStrem = new AdsStream((byte[])tcVarList[index].Data, offset, length);
                        tcStreamWriter = new AdsBinaryWriter(_DataStrem);
                        tcStreamWriter.Write((byte)data);
                        tcClient.Write(tcVarList[index].Handle, _DataStrem);
                        break;
                    case "arbool":
                        break;
                    case "int":
                        break;
                    case "arint":
                        break;
                    case "string":
                        break;
                    case "real":
                        break;
                    case "lreal":
                        break;
                }
                tcStreamWriter.Close();
            }
            catch (Exception ex)
            {
                return tcFunctionResult.TC_FAIL_TO_WRITE_DATA;
            }
            finally
            {
                tcStreamWriter.Close();
            }
            return tcFunctionResult.TC_SUCCESS;
        }
        #endregion

        public static void tcSetData(tcDataType type, int index, int offset, object value)
        {
            if (!tcClient.IsConnected)
            {
                return;
            }

            if (index > tcVarList.Count || index < 0)
            {
                return;
            }

            AdsStream _DataStrem = new AdsStream(tcVarList[index].Size);
            AdsBinaryWriter tcStreamWriter = new AdsBinaryWriter(_DataStrem);

            switch (type)
            {
                case tcDataType.BOOL:
                    {
                        bool[] ret = new bool[tcVarList[index].Size * 8];

                        if (tcVarList[index].Type.ToLower().Equals("byte"))
                        {
                            byte[] byteArray = new byte[tcVarList[index].Size];
                            BitArray ba = new BitArray((byte[])tcVarList[index].Data);
                            ba[offset] = (bool)value;
                            ba.CopyTo(byteArray, 0);
                            tcStreamWriter.Write(byteArray);
                            tcClient.Write(tcVarList[index].Handle, _DataStrem);
                        }
                    }
                    break;
                case tcDataType.BYTE:
                    {
                        if (tcVarList[index].Type.ToLower().Equals("byte"))
                        {
                            byte[] byteArray = (byte[])tcVarList[index].Data;
                            byteArray[offset] = Convert.ToByte(value);
                            tcStreamWriter.Write(byteArray);
                            tcClient.Write(tcVarList[index].Handle, _DataStrem);
                        }
                    }
                    break;
                case tcDataType.REAL:
                    {
                        if (tcVarList[index].Type.ToLower().Equals("byte"))
                        {
                            byte[] byteArray = (byte[])tcVarList[index].Data;
                            float val = Convert.ToSingle(value);
                            byte[] sourceArray = BitConverter.GetBytes(val);

                            Array.Copy(sourceArray, 0, byteArray, offset, 4);
                            tcStreamWriter.Write(byteArray);
                            tcClient.Write(tcVarList[index].Handle, _DataStrem);
                        }
                    }
                    break;
            }
        }

        #region Retrieve data from list
        public static object tcGetData(tcDataType type, int index, int offset)
        {
            object result = 0;

            if (index >= tcVarList.Count || index < 0) return null;

            switch (type)
            {
                case tcDataType.BYTE:

                    if (tcVarList[index].Type.ToLower().Equals("byte"))
                    {
                        byte[] byteArr = (byte[])tcVarList[index].Data;
                        result = byteArr[offset];
                    }
                    break;
                case tcDataType.INT16:
                    if (tcVarList[index].Type.ToLower().Equals("byte"))
                    {
                        byte[] byteArr = (byte[])tcVarList[index].Data;
                        result = BitConverter.ToInt16(byteArr, offset);
                    }
                    break;
                case tcDataType.INT32:
                    if (tcVarList[index].Type.ToLower().Equals("byte"))
                    {
                        byte[] byteArr = (byte[])tcVarList[index].Data;
                        result = BitConverter.ToInt32(byteArr, offset);
                    }
                    break;
                case tcDataType.REAL:
                    if (tcVarList[index].Type.ToLower().Equals("byte"))
                    {
                        byte[] byteArr = (byte[])tcVarList[index].Data;
                        result = BitConverter.ToSingle(byteArr, offset);
                    }
                    break;
                case tcDataType.LREAL:
                    if (tcVarList[index].Type.ToLower().Equals("byte"))
                    {
                        byte[] byteArr = (byte[])tcVarList[index].Data;
                        result = BitConverter.ToDouble(byteArr, offset);
                    }
                    break;
                case tcDataType.BOOL:
                    // bool_array's min length is 8 bit (1 byte) 
                    bool[] bRet = new bool[tcVarList[index].Size * 8];

                    if (tcVarList[index].Type.ToLower().Equals("byte"))
                    {
                        BitArray ba = new BitArray((byte[])tcVarList[index].Data);
                        ba.CopyTo(bRet, 0);
                        result = bRet[offset];
                    }
                    else if (tcVarList[index].Type.ToLower().Equals("arbool"))
                    {
                        bRet = (bool[])tcVarList[index].Data;
                        result = bRet[offset];
                    }
                    break;
                case tcDataType.STRING_32:

                    StringBuilder sb = new StringBuilder();

                    if (tcVarList[index].Type.ToLower().Equals("byte"))
                    {
                        byte[] byteArr = (byte[])tcVarList[index].Data;
                        sb.Append(byteArr.Skip(offset).Take(32));
                        result = sb.ToString();
                    }
                    break;
            }

            return result;

        }
        #endregion

        #region Ends the connection
        public static void tcDispose()
        {
            int totalCount = tcVarList.Count;
            for (int i = 0; i < totalCount; i++)
            {
                int j = totalCount - (i + 1);
                if (tcVarList[j].Handle != 0) tcClient.DeleteVariableHandle(tcVarList[j].Handle);
                tcVarList.RemoveAt(j);
            }

            for (int i = 0; i < Axis_MaxAxes; i++)
            {
                if (tcAxFeedback[i].handle != 0) tcClient.DeleteVariableHandle(tcAxFeedback[i].handle);
                tcAxFeedback[i].handle = 0;
                if (tcAxCommand[i].handle != 0) tcClient.DeleteVariableHandle(tcAxCommand[i].handle);
                tcAxCommand[i].handle = 0;
            }

            tcClient.Dispose();
            //LogMessage(string.Format("{0}\t: {1}", "Report", "Device connection terminated."));
        }
        #endregion


        #region TwinCAT Axis & HMI
        static public tcFunctionResult tcUpdateAxStatus()
        {
            if (!tcClient.IsConnected) return tcFunctionResult.TC_NOT_CONNECTED;
            if (Axis_MaxAxes <= 0) return tcFunctionResult.TC_NO_AXIS;
            for (int k = 0; k < Axis_MaxAxes; k++)
            {
                AdsStream _DataStream = new AdsStream(tcAxFeedback[k].size);
                AdsBinaryReader _DataReader = new AdsBinaryReader(_DataStream);
                try
                {
                    tcClient.Read(tcAxFeedback[k].handle, _DataStream);
                    tcAxFeedback[k].actualPosition = _DataReader.ReadDouble();
                    tcAxFeedback[k].actualVelocity = _DataReader.ReadDouble();
                    tcAxFeedback[k].setPosition = _DataReader.ReadDouble();
                    tcAxFeedback[k].setVelocity = _DataReader.ReadDouble();
                    tcAxFeedback[k].controlleroverride = _DataReader.ReadDouble();
                    tcAxFeedback[k].ErrorId = _DataReader.ReadUInt32();
                    tcAxFeedback[k].hasError = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isReady = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isDisabled = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isFwDisabled = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isBwDisabled = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isCalibrated = _DataReader.ReadBoolean();
                    tcAxFeedback[k].hasJob = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isNotMoving = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isPositiveDirection = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isNegativeDirection = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isInTarget = _DataReader.ReadBoolean();
                    tcAxFeedback[k].isInRange = _DataReader.ReadBoolean();
                }
                catch (Exception ex)
                {
                    //LogMessage(string.Format("{0}\t: {1}", "Error", "Failed to read PlcToHmi" + ex.Message));
                    _DataReader.Close();
                    return tcFunctionResult.TC_FAIL_TO_READ_AXIS_FEEDBACK;
                }
                _DataReader.Close();
            }
            return tcFunctionResult.TC_SUCCESS;
        }
        static public Axis_PlcToHmi tcGetAxsPlcToHmi(int index)
        {
            if (!tcClient.IsConnected) return null;
            if (Axis_MaxAxes <= 0) return null;
            if (index < 0 || index > Axis_MaxAxes - 1) return null;

            AdsStream _DataStream = new AdsStream(tcAxFeedback[index].size);
            AdsBinaryReader _DataReader = new AdsBinaryReader(_DataStream);
            try
            {
                Axis_PlcToHmi _buffer = new Axis_PlcToHmi();
                tcClient.Read(tcAxFeedback[index].handle, _DataStream);
                _buffer.actualPosition = _DataReader.ReadDouble();
                _buffer.actualVelocity = _DataReader.ReadDouble();
                _buffer.setPosition = _DataReader.ReadDouble();
                _buffer.setVelocity = _DataReader.ReadDouble();
                _buffer.controlleroverride = _DataReader.ReadDouble();
                _buffer.ErrorID = _DataReader.ReadUInt32();
                _buffer.hasError = _DataReader.ReadBoolean();
                _buffer.isReady = _DataReader.ReadBoolean();
                _buffer.isDisabled = _DataReader.ReadBoolean();
                _buffer.isFwDisabled = _DataReader.ReadBoolean();
                _buffer.isBwDisabled = _DataReader.ReadBoolean();
                _buffer.isCalibrated = _DataReader.ReadBoolean();
                _buffer.hasJob = _DataReader.ReadBoolean();
                _buffer.isNotMoving = _DataReader.ReadBoolean();
                _buffer.isPositiveDirection = _DataReader.ReadBoolean();
                _buffer.isNegativeDirection = _DataReader.ReadBoolean();
                _buffer.isInTarget = _DataReader.ReadBoolean();
                _buffer.isInRange = _DataReader.ReadBoolean();
                return _buffer;
            }
            catch (Exception ex)
            {
                //LogMessage(string.Format("{0}\t: {1}", "Error", "Failed to read PlcToHmi" + ex.Message));
                _DataReader.Close();
                return null;
            }
        }
        static public tcFunctionResult tcGetAxisFeedback(int index, ref Axis_PlcToHmi RESULT)
        {
            if (!tcClient.IsConnected) return tcFunctionResult.TC_NOT_CONNECTED;
            if (Axis_MaxAxes <= 0) return tcFunctionResult.TC_NO_AXIS;
            if (index < 0 || index > Axis_MaxAxes - 1) return tcFunctionResult.TC_AXIS_OUTOFBOUND;

            AdsStream _DataStream = new AdsStream(tcAxFeedback[index].size);
            AdsBinaryReader _DataReader = new AdsBinaryReader(_DataStream);
            try
            {
                tcClient.Read(tcAxFeedback[index].handle, _DataStream);

                RESULT.actualPosition = _DataReader.ReadDouble();
                RESULT.actualVelocity = _DataReader.ReadDouble();
                RESULT.setPosition = _DataReader.ReadDouble();
                RESULT.setVelocity = _DataReader.ReadDouble();
                RESULT.controlleroverride = _DataReader.ReadDouble();
                RESULT.ErrorID = _DataReader.ReadUInt32();
                RESULT.hasError = _DataReader.ReadBoolean();
                RESULT.isReady = _DataReader.ReadBoolean();
                RESULT.isDisabled = _DataReader.ReadBoolean();
                RESULT.isFwDisabled = _DataReader.ReadBoolean();
                RESULT.isBwDisabled = _DataReader.ReadBoolean();
                RESULT.isCalibrated = _DataReader.ReadBoolean();
                RESULT.hasJob = _DataReader.ReadBoolean();
                RESULT.isNotMoving = _DataReader.ReadBoolean();
                RESULT.isPositiveDirection = _DataReader.ReadBoolean();
                RESULT.isNegativeDirection = _DataReader.ReadBoolean();
                RESULT.isInTarget = _DataReader.ReadBoolean();
                RESULT.isInRange = _DataReader.ReadBoolean();

            }
            catch (Exception ex)
            {
                _DataReader.Close();
                return tcFunctionResult.TC_FAIL_TO_READ_AXIS_FEEDBACK;
            }

            _DataReader.Close();
            return tcFunctionResult.TC_SUCCESS;
        }

        static public tcFunctionResult tcSetAxisCommand(int index)
        {
            if (!tcClient.IsConnected) return tcFunctionResult.TC_NOT_CONNECTED;
            if (Axis_MaxAxes <= 0) return tcFunctionResult.TC_NO_AXIS;
            if (index < 0 || index >= Axis_MaxAxes) return tcFunctionResult.TC_AXIS_OUTOFBOUND;

            AdsStream _dataStream = new AdsStream(tcAxCommand[index].size);
            AdsBinaryWriter _dataWriter = new AdsBinaryWriter(_dataStream);

            _dataWriter.Write(tcAxCommand[index].TARGET_POSITION);
            _dataWriter.Write(tcAxCommand[index].TARGET_VELOCITY);
            _dataWriter.Write(tcAxCommand[index].TARGET_ACCELERATION);
            _dataWriter.Write(tcAxCommand[index].TARGET_DECELERATION);
            _dataWriter.Write(tcAxCommand[index].TARGET_JERK);
            _dataWriter.Write(tcAxCommand[index].CONTROLLER_OVERRIDE);
            _dataWriter.Write(tcAxCommand[index].SERVO_ON);
            _dataWriter.Write(tcAxCommand[index].SERVO_ON_BW);
            _dataWriter.Write(tcAxCommand[index].SERVO_ON_FW);
            _dataWriter.Write(tcAxCommand[index].SERVO_OFF);
            _dataWriter.Write(tcAxCommand[index].SERVO_MOVE_ABS);
            _dataWriter.Write(tcAxCommand[index].SERVO_MOVE_REL);
            _dataWriter.Write(tcAxCommand[index].SERVO_HALT);
            _dataWriter.Write(tcAxCommand[index].SERVO_HOME);
            _dataWriter.Write(tcAxCommand[index].SERVO_RESET);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_MODE);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_FW_FAST);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_BW_FAST);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_FW_SLOW);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_BW_SLOW);

            try
            {
                tcClient.Write(tcAxCommand[index].handle, _dataStream);
            }
            catch (Exception ex)
            {
                _dataWriter.Close();
                return tcFunctionResult.TC_GENERAL_FAILURE_1;
            }
            _dataWriter.Close();
            return tcFunctionResult.TC_SUCCESS;
        }

        static public tcFunctionResult tcSetAxisCommand(int index, Axis_HmiToPlc COMMAND)
        {
            if (!tcClient.IsConnected) return tcFunctionResult.TC_NOT_CONNECTED;
            if (Axis_MaxAxes <= 0) return tcFunctionResult.TC_NO_AXIS;
            if (index < 0 || index >= Axis_MaxAxes) return tcFunctionResult.TC_AXIS_OUTOFBOUND;

            tcAxCommand[index].CONTROLLER_OVERRIDE = COMMAND.CONTROLLER_OVERRIDE;
            tcAxCommand[index].SERVO_HOME = COMMAND.SERVO_HOME;
            tcAxCommand[index].SERVO_JOG_BW_FAST = COMMAND.SERVO_JOG_BW_FAST;
            tcAxCommand[index].SERVO_JOG_BW_SLOW = COMMAND.SERVO_JOG_BW_SLOW;
            tcAxCommand[index].SERVO_JOG_FW_FAST = COMMAND.SERVO_JOG_FW_FAST;
            tcAxCommand[index].SERVO_JOG_FW_SLOW = COMMAND.SERVO_JOG_FW_SLOW;
            tcAxCommand[index].SERVO_JOG_MODE = COMMAND.SERVO_JOG_MODE;
            tcAxCommand[index].SERVO_MOVE_ABS = COMMAND.SERVO_MOVE_ABS;
            tcAxCommand[index].SERVO_MOVE_REL = COMMAND.SERVO_MOVE_REL;
            tcAxCommand[index].SERVO_HALT = COMMAND.SERVO_HALT;
            tcAxCommand[index].SERVO_OFF = COMMAND.SERVO_OFF;
            tcAxCommand[index].SERVO_ON = COMMAND.SERVO_ON;
            tcAxCommand[index].SERVO_ON_BW = COMMAND.SERVO_ON_BW;
            tcAxCommand[index].SERVO_ON_FW = COMMAND.SERVO_ON_FW;
            tcAxCommand[index].SERVO_RESET = COMMAND.SERVO_RESET;
            tcAxCommand[index].TARGET_ACCELERATION = COMMAND.TARGET_ACCELERATION;
            tcAxCommand[index].TARGET_DECELERATION = COMMAND.TARGET_DECELERATION;
            tcAxCommand[index].TARGET_JERK = COMMAND.TARGET_JERK;
            tcAxCommand[index].TARGET_POSITION = COMMAND.TARGET_POSITION;
            tcAxCommand[index].TARGET_VELOCITY = COMMAND.TARGET_VELOCITY;

            AdsStream _dataStream = new AdsStream(tcAxCommand[index].size);
            AdsBinaryWriter _dataWriter = new AdsBinaryWriter(_dataStream);

            _dataWriter.Write(tcAxCommand[index].TARGET_POSITION);
            _dataWriter.Write(tcAxCommand[index].TARGET_VELOCITY);
            _dataWriter.Write(tcAxCommand[index].TARGET_ACCELERATION);
            _dataWriter.Write(tcAxCommand[index].TARGET_DECELERATION);
            _dataWriter.Write(tcAxCommand[index].TARGET_JERK);
            _dataWriter.Write(tcAxCommand[index].CONTROLLER_OVERRIDE);
            _dataWriter.Write(tcAxCommand[index].SERVO_ON);
            _dataWriter.Write(tcAxCommand[index].SERVO_ON_BW);
            _dataWriter.Write(tcAxCommand[index].SERVO_ON_FW);
            _dataWriter.Write(tcAxCommand[index].SERVO_OFF);
            _dataWriter.Write(tcAxCommand[index].SERVO_MOVE_ABS);
            _dataWriter.Write(tcAxCommand[index].SERVO_MOVE_REL);
            _dataWriter.Write(tcAxCommand[index].SERVO_HALT);
            _dataWriter.Write(tcAxCommand[index].SERVO_HOME);
            _dataWriter.Write(tcAxCommand[index].SERVO_RESET);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_MODE);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_FW_FAST);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_BW_FAST);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_FW_SLOW);
            _dataWriter.Write(tcAxCommand[index].SERVO_JOG_BW_SLOW);
            try
            {
                tcClient.Write(tcAxCommand[index].handle, _dataStream);
            }
            catch (Exception ex)
            {
                _dataWriter.Close();
                return tcFunctionResult.TC_GENERAL_FAILURE_1;
            }
            _dataWriter.Close();
            return tcFunctionResult.TC_SUCCESS;
        }
        #endregion

    }
}
