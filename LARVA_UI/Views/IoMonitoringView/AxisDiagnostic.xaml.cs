using EPLE.App;
using EPLE.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TwinCAT.TypeSystem;

namespace LARVA_UI.Views
{
    /// <summary>
    /// AxisDiagnostic.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AxisDiagnostic : UserControl
    {
        public AxisDiagnostic()
        {
            InitializeComponent();
        }

        private System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        public string AxisName
        {
            get { return AxisLabel.Content.ToString(); }
            set { AxisLabel.Content = value; }
        }
        public int ID { get; set; }

        private void ControlSet_Click(object sender, RoutedEventArgs e)
        {
            switch(ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands

                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);

                        #endregion
                        */
                    }
                    break;
            }
        }

        private void JogBwFast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch(ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void JogBwFast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void JogFwFast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void JogFwFast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void JogFwSlow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, true);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void JogFwSlow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void JogBwSlow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void JogBwSlow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void AxisReset_Click(object sender, RoutedEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void Move_Abs_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(TargetVelocity.Text) <= 0) return;

            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, double.Parse(TargetAcceleration.Text));
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, double.Parse(TargetDeceleration.Text));
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, double.Parse(TargetDeceleration.Text));
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, double.Parse(TargetPosition.Text));
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, double.Parse(TargetVelocity.Text));
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void Move_Rel_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(TargetVelocity.Text) <= 0) return;

            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, double.Parse(TargetAcceleration.Text));
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, double.Parse(TargetDeceleration.Text));
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, double.Parse(TargetDeceleration.Text));
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, double.Parse(TargetPosition.Text));
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, double.Parse(TargetVelocity.Text));
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, true);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, false);
                        #endregion
                        */
                    }
                    break;
            }
        }

        private void Halt_Click(object sender, RoutedEventArgs e)
        {
            switch (ID)
            {
                case 0:
                    {
                        /*
                        #region Servo Enable/Disable
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_OFF, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON, (bool)EnableControl.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_BW, (bool)EnableBw.IsChecked);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_ON_FW, (bool)EnableFw.IsChecked);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_CONTROL_OVERRIDE, AxisOverride.Value);
                        #endregion
                        #region Servo motion dynamics
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_ACC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_DEC, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_JERK, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_POS, 0);
                        DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.OUT_AXIS_X_TARGET_VEL, 0);
                        #endregion
                        #region Jog mode
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_JOG_MODE, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_BW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_FAST_FW, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_JOG_SLOW_FW, false);
                        #endregion
                        #region Servo movement commands

                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HOME, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_ABS, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_MOVE_REL, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_RESET, false);
                        DataManager.Instance.SET_BOOL_DATA(IoNameHelper.OUT_AXIS_X_SERVO_HALT, true);

                        #endregion
                        */
                    }
                    break;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {

        }
    }
}