using DevExpress.Charts.Designer.Native;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid.HitTest;
using DevExpress.Xpf.PivotGrid;
using DevExpress.XtraReports.UI;
using EPLE.App;
using EPLE.Core.Manager;
using EPLE.IO;
using LARVA_UI.Views;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class SettingsViewModel
    {

        [GenerateProperty]
        private double setPosition_XAxis;
        [GenerateProperty]
        private double setPosition_YAxis;
        [GenerateProperty]
        private double setPosition_ZAxis;
        [GenerateProperty]
        private double setPosition_TAxis;
        [GenerateProperty]
        private double setVelocity_XAxis;
        [GenerateProperty]
        private double setVelocity_YAxis;
        [GenerateProperty]
        private double setVelocity_ZAxis;
        [GenerateProperty]
        private double setVelocity_TAxis;
        [GenerateProperty]
        private double actPosition_XAxis;
        [GenerateProperty]
        private double actPosition_YAxis;
        [GenerateProperty]
        private double actPosition_ZAxis;
        [GenerateProperty]
        private double actPosition_TAxis;
        [GenerateProperty]
        private double actVelocity_XAxis;
        [GenerateProperty]
        private double actVelocity_YAxis;
        [GenerateProperty]
        private double actVelocity_ZAxis;
        [GenerateProperty]
        private double actVelocity_TAxis;
        [GenerateProperty]
        private double targetPosition_XAxis;
        [GenerateProperty]
        private double targetPosition_YAxis;
        [GenerateProperty]
        private double targetPosition_ZAxis;
        [GenerateProperty]
        private double targetPosition_TAxis;
        [GenerateProperty]
        private double targetVelocity_XAxis;
        [GenerateProperty]
        private double targetVelocity_YAxis;
        [GenerateProperty]
        private double targetVelocity_ZAxis;
        [GenerateProperty]
        private double targetVelocity_TAxis;

     

        public SettingsViewModel()
        {
            DataManager.Instance.DataAccess.DataChangedEvent += MotionDataChangedEvent;
            //timer = new DispatcherTimer();
            //timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            //timer.Tick += Timer_Tick;
            //timer.Start();
            Initialize();
        }

        [GenerateCommand]
        private void TAxisTargetVelocityValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetVelocity_TAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void ZAxisTargetVelocityValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetVelocity_ZAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void YAxisTargetVelocityValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetVelocity_YAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void XAxisTargetVelocityValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetVelocity_XAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void TAxisTargetPositionValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetPosition_TAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void ZAxisTargetPositionValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetPosition_ZAxis = Convert.ToDouble(eventArgs.NewValue);
        }
        [GenerateCommand]
        private void YAxisTargetPositionValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetPosition_YAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        [GenerateCommand]
        private void XAxisTargetPositionValueChanged(RoutedEventArgs args)
        {
            EditValueChangingEventArgs eventArgs = args as EditValueChangingEventArgs;

            TargetPosition_XAxis = Convert.ToDouble(eventArgs.NewValue);
        }

        private void MotionDataChangedEvent(object sender, DataChangedEventHandlerArgs e)
        {
            EPLE.IO.Data data = e.Data;

            if (data.Name.Equals(IoNameHelper.iXAxis_dSet_Pos))
            {
                SetPosition_XAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_dSet_Velo))
            {
                SetVelocity_XAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_dAct_Pos))
            {
                ActPosition_XAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_dAct_Velo))
            {
                ActVelocity_XAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dSet_Pos))
            {
                SetPosition_YAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dSet_Velo))
            {
                SetVelocity_YAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dAct_Pos))
            {
                ActPosition_YAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dAct_Velo))
            {
                ActVelocity_YAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_dSet_Pos))
            {
                SetPosition_ZAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_dSet_Velo))
            {
                SetVelocity_ZAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_dAct_Pos))
            {
                ActPosition_ZAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_dAct_Velo))
            {
                ActVelocity_ZAxis = (double)data.Value;
            }

            else if (data.Name.Equals(IoNameHelper.iTAxis_dSet_Pos))
            {
                SetPosition_TAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_dSet_Velo))
            {
                SetVelocity_TAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_dAct_Pos))
            {
                ActPosition_TAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_dAct_Velo))
            {
                ActVelocity_TAxis = (double)data.Value;
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_nStatus_IsDisabled) 
                || data.Name.Equals(IoNameHelper.iXAxis_nStatus_IsCalibrated)
                || data.Name.Equals(IoNameHelper.iXAxis_nStatus_HasErr))
            {
                ServoState_XAxis = ServoStateConverter(1);
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_nStatus_IsDisabled)
                || data.Name.Equals(IoNameHelper.iYAxis_nStatus_IsCalibrated)
                || data.Name.Equals(IoNameHelper.iYAxis_nStatus_HasErr))
             {
                 ServoState_YAxis = ServoStateConverter(2);
             }
            else if (data.Name.Equals(IoNameHelper.iZAxis_nStatus_IsDisabled)
                || data.Name.Equals(IoNameHelper.iZAxis_nStatus_IsCalibrated)
                || data.Name.Equals(IoNameHelper.iZAxis_nStatus_HasErr))
            {
                ServoState_ZAxis = ServoStateConverter(3);
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_nStatus_IsDisabled)
                || data.Name.Equals(IoNameHelper.iTAxis_nStatus_IsCalibrated)
                || data.Name.Equals(IoNameHelper.iTAxis_nStatus_HasErr))
            {
                ServoState_TAxis = ServoStateConverter(4);
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_nStatus_IsReady))
            {
                ServoReady_XAxis = ServoReady(1);
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_nStatus_IsReady))
            {
                ServoReady_YAxis = ServoReady(2);
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_nStatus_IsReady))
            {
                ServoReady_ZAxis = ServoReady(3);
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_nStatus_IsReady))
            {
                ServoReady_TAxis = ServoReady(4);
            }
            else if (data.Name.Equals(IoNameHelper.iXAxis_nStatus_IsNotMove))
            {
                servoNotMoving_XAxis = ServoNotMoving(1);
            }
            else if (data.Name.Equals(IoNameHelper.iYAxis_nStatus_IsNotMove))
            {
                servoNotMoving_YAxis = ServoNotMoving(2);
            }
            else if (data.Name.Equals(IoNameHelper.iZAxis_nStatus_IsNotMove))
            {
                servoNotMoving_ZAxis = ServoNotMoving(3);
            }
            else if (data.Name.Equals(IoNameHelper.iTAxis_nStatus_IsNotMove))
            {
                servoNotMoving_TAxis = ServoNotMoving(4);
            }
        }


        private void Initialize()
        {
            bool result;

            TargetPosition_XAxis = 0;

            ServoState_XAxis = ServoStateConverter(1);
            ServoReady_XAxis = ServoReady(1);
            ServoNotMoving_XAxis = ServoNotMoving(1);

            ServoState_YAxis = ServoStateConverter(2);
            ServoReady_YAxis = ServoReady(2);
            ServoNotMoving_YAxis = ServoNotMoving(2);

            ServoState_ZAxis = ServoStateConverter(3);
            ServoReady_ZAxis = ServoReady(3);
            ServoNotMoving_ZAxis = ServoNotMoving(3);

            ServoState_TAxis = ServoStateConverter(4);
            ServoReady_TAxis = ServoReady(4);
            ServoNotMoving_TAxis = ServoNotMoving(4);

            double setPosX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dSet_Pos, out result);

            if (result) 
                SetPosition_XAxis = setPosX;
            else 
                SetPosition_XAxis = 0.0;

            double setVelX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dSet_Velo, out result);

            if (result)
                SetVelocity_XAxis = setVelX;
            else
                SetVelocity_XAxis = 0.0;

            double actPosX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dAct_Pos, out result);

            if (result)
                ActPosition_XAxis = actPosX;
            else
                ActPosition_XAxis    = 0.0;

            double actVelX = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dAct_Velo, out result);

            if (result)
                ActVelocity_XAxis = actVelX;
            else
                ActVelocity_XAxis = 0.0;
         
            double setPosY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dSet_Pos, out result);

            if (result)
                SetPosition_YAxis = setPosY;
            else
                SetPosition_YAxis = 0.0;

            double setVelY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dSet_Velo, out result);

            if (result)
                SetVelocity_YAxis = setVelY;
            else
                SetVelocity_YAxis = 0.0;

            double actPosY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dAct_Pos, out result);

            if (result)
                ActPosition_YAxis = actPosY;
            else
                ActPosition_YAxis = 0.0;

            double actVelY = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dAct_Velo, out result);

            if (result)
                ActVelocity_YAxis = actVelY;
            else
                ActVelocity_YAxis = 0.0;

            double setPosZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dSet_Pos, out result);

            if (result)
                SetPosition_ZAxis = setPosZ;
            else
                SetPosition_ZAxis = 0.0;

            double setVelZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dSet_Velo, out result);

            if (result)
                SetVelocity_ZAxis = setVelZ;
            else
                SetVelocity_ZAxis = 0.0;

            double actPosZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dAct_Pos, out result);

            if (result)
                ActPosition_ZAxis = actPosZ;
            else
                ActPosition_ZAxis = 0.0;

            double actVelZ = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dAct_Velo, out result);

            if (result)
                ActVelocity_ZAxis = actVelZ;
            else
                ActVelocity_ZAxis = 0.0;

            double setPosT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTAxis_dSet_Pos, out result);

            if (result)
                SetPosition_TAxis = setPosT;
            else
                SetPosition_TAxis = 0.0;

            double setVelT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTAxis_dSet_Velo, out result);

            if (result)
                SetVelocity_TAxis = setVelT;
            else
                SetVelocity_TAxis = 0.0;

            double actPosT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTAxis_dAct_Pos, out result);

            if (result)
                ActPosition_TAxis = actPosT;
            else
                ActPosition_TAxis = 0.0;

            double actVelT = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iTAxis_dAct_Velo, out result);

            if (result)
                ActVelocity_TAxis = actVelT;
            else
                ActVelocity_TAxis = 0.0;
        }

        [GenerateCommand]
        private void XAxisJogNegativeSlowTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogNegativeSlowTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogPositiveSlowTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }
        [GenerateCommand]
        private void XAxisJogPositiveSlowTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogNegativeFastTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogNegativeFastTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogNegativeSlowButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogNegativeSlowButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }


        [GenerateCommand]
        private void XAxisJogPositiveSlowButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogPositiveSlowButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogNegativeFastButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogNegativeFastButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogPositiveFastButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogPositiveFastButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisJogPositiveFastTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void XAxisJogPositiveFastTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void XAxisServoResetClicked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Reset, true);
            //Thread.Sleep(500);
            //bool tmp = true;
            //tmp = DataManager.Instance.GET_BOOL_DATA(IoNameHelper.iXAxis_nStatus_HasErr, out bool result);
            //if (tmp == false)
            //{
            //    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Reset, false);
            //}
        }

        [GenerateCommand]
        private void XAxisServoDisableClicked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Off, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_On, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_BwOn, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_FwOn, false);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dCtrl_Override, 0);
        }

        [GenerateCommand]
        private void XAxisServoEnableClicked(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Off, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_On, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_BwOn, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_FwOn, true);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dCtrl_Override, 100);
        }

        [GenerateCommand]
        private void XAxisServoHome(RoutedEventArgs args)
        {
            //DataManager.Instance.SET_BOOL_DATA(IoNameHelper., true);
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_MANU_X_HOME");
            //FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_AUTO_TOBBAB_CHANGE");
        }

        [GenerateCommand]
        private void XAxisServoHalt(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_Halt, true);
        }

        [GenerateCommand]
        private void XAxisServoMoveTo(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dTarget_Pos, (double)TargetPosition_XAxis);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dTarget_Velo, (double)TargetVelocity_XAxis);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void XAxisServoMoveBy(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dTarget_Pos, (double)TargetPosition_XAxis);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oXAxis_dTarget_Velo, (double)TargetVelocity_XAxis);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nServo_MoveREL, true);
        }


        [GenerateCommand]
        private void YAxisJogPositiveFastTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogPositiveFastTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeSlowTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogNegativeSlowTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogPositiveSlowTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }
        [GenerateCommand]
        private void YAxisJogPositiveSlowTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeFastTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogNegativeFastTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeSlowButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogNegativeSlowButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogPositiveSlowButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogPositiveSlowButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeFastButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogNegativeFastButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisJogPositiveFastButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void YAxisJogPositiveFastButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void YAxisServoReset(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Reset, true);
        }

        [GenerateCommand]
        private void YAxisServoDisable(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Off, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_On, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_BwOn, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_FwOn, false);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dCtrl_Override, 0);
        }

        [GenerateCommand]
        private void YAxisServoEnable(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Off, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_On, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_BwOn, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_FwOn, true);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dCtrl_Override, 100);
        }

        [GenerateCommand]
        private void YAxisServoHome(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_MANU_Y_HOME");
        }

        [GenerateCommand]
        private void YAxisServoHalt(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_Halt, true);
        }

        [GenerateCommand]
        private void YAxisServoMoveTo(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Pos, (double)TargetPosition_YAxis);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Velo, (double)TargetVelocity_YAxis);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void YAxisServoMoveBy(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Pos, (double)TargetPosition_YAxis);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oYAxis_dTarget_Velo, (double)TargetVelocity_YAxis);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nServo_MoveREL, true);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveFastTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }
        [GenerateCommand]
        private void ZAxisJogPositiveFastTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeSlowTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeSlowTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveSlowTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveSlowTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeFastTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeFastTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }
        [GenerateCommand]
        private void ZAxisJogNegativeSlowButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeSlowButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveSlowButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveSlowButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeFastButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogNegativeFastButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveFastButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void ZAxisJogPositiveFastButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisServoReset(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Reset, true);
        }

        [GenerateCommand]
        private void ZAxisServoDisable(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Off, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_On, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_BwOn, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_FwOn, false);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dCtrl_Override, 0);
        }

        [GenerateCommand]
        private void ZAxisServoEnable(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Off, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_On, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_BwOn, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_FwOn, true);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dCtrl_Override, 100);
        }

        [GenerateCommand]
        private void TAxisJogPositiveFastTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void ZAxisServoHome(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_MANU_Z_HOME");
        }

        [GenerateCommand]
        private void ZAxisServoHalt(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_Halt, true);
        }

        [GenerateCommand]
        private void ZAxisServoMoveTo(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Pos, (double)TargetPosition_ZAxis);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Velo, (double)TargetVelocity_ZAxis);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void ZAxisServoMoveBy(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Pos, (double)TargetPosition_ZAxis);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oZAxis_dTarget_Velo, (double)TargetVelocity_ZAxis);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nServo_MoveREL, true);
        }

        [GenerateCommand]
        private void TAxisJogPositiveFastTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeSlowTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogNegativeSlowTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogPositiveSlowTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogPositiveSlowTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeFastTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogNegativeFastTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeSlowButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogNegativeSlowButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogPositiveSlowButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogPositiveSlowButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeFastButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogNegativeFastButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }

        [GenerateCommand]
        private void TAxisJogPositiveFastButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, true);
        }

        [GenerateCommand]
        private void TAxisJogPositiveFastButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_BwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nJog_Mode, false);
        }


        [GenerateCommand]
        private void TAxisServoReset(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Reset, true);
        }


        [GenerateCommand]
        private void TAxisServoDisable(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Off, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_On, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_BwOn, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_FwOn, false);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dCtrl_Override, 0);
        }

        [GenerateCommand]
        private void TAxisServoEnable(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Off, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_On, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_BwOn, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_FwOn, true);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dCtrl_Override, 100);
        }
        [GenerateCommand]
        private void TAxisServoHome(RoutedEventArgs args)
        {
            FunctionManager.Instance.EXECUTE_FUNCTION_ASYNC("F_MANU_FLIP_HOME");
        }

        [GenerateCommand]
        private void TAxisServoHalt(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_Halt, true);
        }

        [GenerateCommand]
        private void TAxisServoMoveTo(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dTarget_Pos, (double)TargetPosition_TAxis);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dTarget_Velo, (double)TargetVelocity_TAxis);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_MoveABS, true);
        }

        [GenerateCommand]
        private void TAxisServoMoveBy(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dTarget_Pos, (double)TargetPosition_TAxis);
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oTAxis_dTarget_Velo, (double)TargetVelocity_TAxis);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oTAxis_nServo_MoveREL, true);
        }

        [GenerateCommand]
        void TabControlLoaded(RoutedEventArgs args)
        {
            //DXTabControl dXTabControl = (DXTabControl)args.Source;

            //#region AXIS


            //int axis_count = DataManager.Instance.GET_INT_DATA(IoNameHelper.IN_INT_MOTION_AXIS_COUNT, out bool result);

            //for (int i = 0; i < axis_count; i++)
            //{
            //    DXTabItem AxisTab = new DXTabItem();
            //    AxisTab.Header = "Axis " + i.ToString();
            //    MotionDiagnostic AxisDiagObj = new MotionDiagnostic();
            //    AxisDiagObj.ID = i;
            //    AxisDiagObj.AxisName = "Axis " + (i + 1).ToString();
            //    //AxisDiagObj.ControlSetClicked += AxDiagSetControl_Clicked;
            //    //AxisDiagObj.JogBwFastClicked += AxisDiagObj_JogBwFastClicked;
            //    //AxisDiagObj.JogBwSlowClicked += AxisDiagObj_JogBwSlowClicked;
            //    //AxisDiagObj.JogFwFastClicked += AxisDiagObj_JogFwFastClicked;
            //    //AxisDiagObj.JogFwSlowClicked += AxisDiagObj_JogFwSlowClicked;
            //    //AxisDiagObj.ResetClicked += AxisDiagObj_ResetClicked;
            //    //AxisDiagObj.MoveAbsClicked += AxisDiagObj_MoveAbsClicked;
            //    //AxisDiagObj.MoveRelClicked += AxisDiagObj_MoveRelClicked;
            //    AxisTab.Content = AxisDiagObj;
            //    dXTabControl.Items.Add(AxisTab);
            //    //MainContent.Items.Add(AxisTab);
            //}
            //#endregion
        }

        [GenerateCommand]
        void SelectionChanged(TabControlSelectionChangedEventArgs arg)
        {
            //DXTabItem tab = (DXTabItem)arg.NewSelectedItem;
            //StackPanel sp = (StackPanel)tab.Content;
            //// Motion Setting Tab
            //if (arg.NewSelectedIndex == 0)
            //{
            //    int axis_count = DataManager.Instance.GET_INT_DATA(IoNameHelper.IN_INT_MOTION_AXIS_COUNT, out bool result);

            //    for (int i = 0; i < axis_count; i++)
            //    {
            //        MotionSettingView motionSettingView = new MotionSettingView();
            //        motionSettingView.
            //    }
            //}
            
        }
    }
}
