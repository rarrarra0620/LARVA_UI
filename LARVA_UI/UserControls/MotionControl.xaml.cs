using LARVA_UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Mvvm;
using static LARVA_UI.UserControls.DigitalIndicator;
using DevExpress.Charts.Designer.Native;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.XtraGauges.Core.Model;

namespace LARVA_UI.UserControls
{
    /// <summary>
    /// Interaction logic for MotionControl.xaml
    /// </summary>
    public partial class MotionControl : UserControl
    {
        private SolidColorBrush _StateOn = Brushes.Green, _StateOff = Brushes.Red, _StateError = Brushes.Yellow, _StateInvalid = Brushes.Gray;
        public MotionControl()
        {
            InitializeComponent();
            StateIndicator.Fill = _StateOff;
            ReadyIndicator.Fill = _StateOff;

        }

        public event EventHandler ServoEnableClicked;
        public event EventHandler ServoDisableClicked;
        public event EventHandler ServoResetClicked;

        public static readonly DependencyProperty ServoAxisNameProperty = DependencyProperty.Register("ServoAxisName", typeof(string), typeof(MotionControl), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty ServoStateProperty = DependencyProperty.Register("ServoState", typeof(string), typeof(MotionControl), new PropertyMetadata(new PropertyChangedCallback(ServoStatePropertyChanged)));

        public static readonly DependencyProperty SetPositionProperty = DependencyProperty.Register("SetPosition", typeof(double), typeof(MotionControl), new PropertyMetadata(new PropertyChangedCallback(SetPositionPropertyChanged)));
        public static readonly DependencyProperty ServoReadyProperty = DependencyProperty.Register("ServoReady", typeof(string), typeof(MotionControl), new PropertyMetadata(new PropertyChangedCallback(ServoReadyPropertyChanged)));

        public static readonly DependencyProperty ServoNotMovingProperty = DependencyProperty.Register("ServoNotMoving", typeof(string), typeof(MotionControl), new PropertyMetadata(new PropertyChangedCallback(ServoNotMovingPropertyChanged)));


        public static readonly DependencyProperty SetVelocityProperty = DependencyProperty.Register("SetVelocity", typeof(double), typeof(MotionControl), new PropertyMetadata(0.0));
        public static readonly DependencyProperty ActualPositionProperty = DependencyProperty.Register("ActualPosition", typeof(double), typeof(MotionControl), new PropertyMetadata(0.0));
        public static readonly DependencyProperty ActualVelocityProperty = DependencyProperty.Register("ActualVelocity", typeof(double), typeof(MotionControl), new PropertyMetadata(0.0));
        public static readonly DependencyProperty TargetPositionProperty = DependencyProperty.Register("TargetPosition", typeof(double), typeof(MotionControl), new PropertyMetadata(0.0));
        public static readonly DependencyProperty TargetVelocityProperty = DependencyProperty.Register("TargetVelocity", typeof(double), typeof(MotionControl), new PropertyMetadata(0.0));
        public static readonly DependencyProperty TargetAccelerationProperty = DependencyProperty.Register("TargetAcceleration", typeof(double), typeof(MotionControl), new PropertyMetadata(0.0));
        public static readonly DependencyProperty TargetDecelerationProperty = DependencyProperty.Register("TargetDeceleration", typeof(double), typeof(MotionControl), new PropertyMetadata(0.0));

        public event EventHandler JogPositiveFastClicked;
        public event EventHandler JogNegativeFastClicked;
        public event EventHandler JogPositiveSlowClicked;
        public event EventHandler JogNegativeSlowClicked;

        public event EventHandler JogPositiveFastMouseLeftButtonDown;
        public event EventHandler JogPositiveFastMouseLeftButtonUp;
        public event EventHandler JogNegativeFastMouseLeftButtonDown;
        public event EventHandler JogNegativeFastMouseLeftButtonUp;
        public event EventHandler JogPositiveSlowMouseLeftButtonDown;
        public event EventHandler JogPositiveSlowMouseLeftButtonUp;
        public event EventHandler JogNegativeSlowMouseLeftButtonDown;
        public event EventHandler JogNegativeSlowMouseLeftButtonUp;

        public event EventHandler JogPositiveFastTouchDown;
        public event EventHandler JogPositiveFastTouchUp;
        public event EventHandler JogNegativeFastTouchDown;
        public event EventHandler JogNegativeFastTouchUp;
        public event EventHandler JogPositiveSlowTouchDown;
        public event EventHandler JogPositiveSlowTouchUp;
        public event EventHandler JogNegativeSlowTouchDown;
        public event EventHandler JogNegativeSlowTouchUp;

        public event EventHandler ServoMoveToClicked;
        public event EventHandler ServoMoveByClicked;
        public event EventHandler ServoHaltClicked;
        public event EventHandler ServoHomeClicked;

        public event EventHandler TargetPositionValueChanged;
        public event EventHandler TargetVelocityValueChanged;

        private void ServoEnable_Click(object sender, RoutedEventArgs e) 
        {
            ServoEnableClicked?.Invoke(sender, e);
        }

        private void ServoDisable_Click(object sender, RoutedEventArgs e)
        {
            ServoDisableClicked?.Invoke(sender, e);
        }

        private void ServoReset_Click(object sender, RoutedEventArgs e)
        {
            ServoResetClicked?.Invoke(sender, e);
        }

        private void JogPositiveFast_Click(object sender, RoutedEventArgs e)
        {
            JogPositiveFastClicked?.Invoke(sender, e);
        }

        private void JogNegativeFast_Click(object sender, RoutedEventArgs e)
        {
            JogNegativeFastClicked?.Invoke(sender, e);
        }

        private void JogPositiveSlow_Click(object sender, RoutedEventArgs e)
        {
            JogPositiveSlowClicked?.Invoke(sender, e);
        }

        private void JogNegativeSlow_Click(object sender, RoutedEventArgs e)
        {
            JogNegativeSlowClicked?.Invoke(sender, e);
        }

        private void JogPositiveFast_ButtonDown(object sender, MouseButtonEventArgs e)
        {
            JogPositiveFastMouseLeftButtonDown?.Invoke(sender, e);
        }

        private void JogPositiveFast_ButtonUp(object sender, MouseButtonEventArgs e)
        {
            JogPositiveFastMouseLeftButtonUp?.Invoke(sender, e);
        }
        
        private void JogNegativeFast_ButtonDown(object sender, MouseButtonEventArgs e)
        {
            JogNegativeFastMouseLeftButtonDown?.Invoke(sender, e);
        }

        private void JogNegativeFast_ButtonUp(object sender, MouseButtonEventArgs e)
        {
            JogNegativeFastMouseLeftButtonUp?.Invoke(sender, e);
        }

        private void JogPositiveSlow_ButtonDown(object sender, MouseButtonEventArgs e)
        {
            JogPositiveSlowMouseLeftButtonDown?.Invoke(sender, e);
        }

        private void JogPositiveSlow_ButtonUp(object sender, MouseButtonEventArgs e)
        {
            JogPositiveSlowMouseLeftButtonUp?.Invoke(sender, e);
        }

        private void JogNegativeSlow_ButtonDown(object sender, MouseButtonEventArgs e)
        {
            JogNegativeSlowMouseLeftButtonDown?.Invoke(sender, e);
        }

        private void JogNegativeSlow_ButtonUp(object sender, MouseButtonEventArgs e)
        {
            JogNegativeSlowMouseLeftButtonUp?.Invoke(sender, e);
        }

        private void JogPositiveFast_TouchDown(object sender, TouchEventArgs e)
        {
            JogPositiveFastTouchDown?.Invoke(sender, e);
        }

        private void JogPositiveFast_TouchUp(object sender, TouchEventArgs e)
        {
            JogPositiveFastTouchUp?.Invoke(sender, e);
        }

        private void JogNegativeFast_TouchDown(object sender, TouchEventArgs e)
        {
            JogNegativeFastTouchDown?.Invoke(sender, e);
        }

        private void JogNegativeFast_TouchUp(object sender, TouchEventArgs e)
        {
            JogNegativeFastTouchUp?.Invoke(sender, e);
        }

        private void JogPositiveSlow_TouchDown(object sender, TouchEventArgs e)
        {
            JogPositiveSlowTouchDown?.Invoke(sender, e);
        }

        private void JogPositiveSlow_TouchUp(object sender, TouchEventArgs e)
        {
            JogPositiveSlowTouchUp?.Invoke(sender, e);
        }

        private void JogNegativeSlow_TouchDown(object sender, TouchEventArgs e)
        {
            JogNegativeSlowTouchDown?.Invoke(sender, e);
        }

        private void JogNegativeSlow_TouchUp(object sender, TouchEventArgs e)
        {
            JogNegativeSlowTouchUp?.Invoke(sender, e);
        }

        private void ServoMoveTo_Click(object sender, RoutedEventArgs e)
        {
            ServoMoveToClicked?.Invoke(sender, e);
        }

        private void ServoMoveBy_Click(object sender, RoutedEventArgs e)
        {
            ServoMoveByClicked?.Invoke(sender, e);
        }

        private void ServoHalt_Click(object sender, RoutedEventArgs e)
        {
            ServoHaltClicked?.Invoke(sender, e);
        }

        private void ServoHome_Click(object sender, RoutedEventArgs e)
        {
            ServoHomeClicked?.Invoke(sender, e);
        }

        
        private void TargetPosition_Click(object sender, RoutedEventArgs e)
        {
            TextEdit textEdit = sender as TextEdit;
            Point controlPosition = textEdit.PointToScreen(new Point(0, 0));

            UserControls.NumericPad numericPad = new UserControls.NumericPad();
            DXDialog dialog = new DXDialog
            {
                Title = "Calculator",
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize
            };

            dialog.Width = 280;
            dialog.Height = 400;

            dialog.Left = controlPosition.X - textEdit.ActualWidth*2;
            dialog.Top = controlPosition.Y + textEdit.ActualHeight;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OK);

            if (result == MessageBoxResult.OK)
            {
                TargetPosition = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }

        private void TargetVelocity_Click(object sender, RoutedEventArgs e)
        {
            TextEdit textEdit = sender as TextEdit;
            Point controlPosition = textEdit.PointToScreen(new Point(0, 0));

            UserControls.NumericPad numericPad = new UserControls.NumericPad();
            DXDialog dialog = new DXDialog
            {
                Title = "Calculator",
                Content = numericPad,
                Owner = Application.Current.MainWindow,
                ResizeMode = ResizeMode.NoResize
            };

            dialog.Width = 280;
            dialog.Height = 400;

            dialog.Left = controlPosition.X - textEdit.ActualWidth*2;
            dialog.Top = controlPosition.Y+textEdit.ActualHeight;

            MessageBoxResult result = dialog.ShowDialog(MessageBoxButton.OK);

            if (result == MessageBoxResult.OK)
            {
                TargetVelocity = Convert.ToDouble(numericPad.txtInput.Text);
            }
        }
        private static void SetPositionPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        private static void ServoReadyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MotionControl mc = (MotionControl)d;

            short state = short.Parse((string)e.NewValue);

            if (state == 1)
            {
                mc.ReadyLabel.Content = "READY";
                mc.ReadyIndicator.Fill = mc._StateOn;
            }
            else
            {
                mc.ReadyLabel.Content = "NOT READY";
                mc.ReadyIndicator.Fill = mc._StateOff;
            }
        }

        private static void ServoStatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MotionControl mc = (MotionControl)d;

            short state = short.Parse((string)e.NewValue);

            switch (state)
            {
                case 0:
                    mc.StateLabel.Content = "SERVO OFF";
                    mc.StateIndicator.Fill = mc._StateOff;
                    break;
                case 1:
                    mc.StateLabel.Content = "SERVO ON";
                    mc.StateIndicator.Fill = mc._StateOn;
                    break;
                case -1:
                    mc.StateLabel.Content = "SERVO ERROR";
                    mc.StateIndicator.Fill = mc._StateError;
                    break;
                default:
                    mc.StateLabel.Content = "SERVO INVALID";
                    mc.StateIndicator.Fill = mc._StateInvalid;
                    break;
            }
        }


        private static void ServoNotMovingPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MotionControl mc = (MotionControl)d;

            short state = short.Parse((string)e.NewValue);

            if (state == 1)
            {
                mc.NotMoving.Content = "MOVING";
                mc.NotMovingIndicator.Fill = mc._StateOn;
            }
            else
            {
                mc.NotMoving.Content = "NOT MOVING";
                mc.NotMovingIndicator.Fill = mc._StateOff;
            }
        }

        private void TextEditSetVelocity_KeyDown(object sender, KeyEventArgs e)
        {
            string name = ServoAxisName;
            ServoAxisName = name;
        }

        private void TextEditActualVelocity_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public string ServoNotMoving
        {
            get { return (string)GetValue(ServoNotMovingProperty); }
            set { SetValue(ServoNotMovingProperty, value); }
        }

        public string ServoReady
        {
            get { return (string)GetValue(ServoReadyProperty); }
            set { SetValue(ServoReadyProperty, value); }
        }

        public string ServoState
        {
            get { return (string)GetValue(ServoStateProperty); }
            set { SetValue(ServoStateProperty, value); }
        }

        public string ServoAxisName
        {
            get { return (string)GetValue(ServoAxisNameProperty); }
            set { SetValue(ServoAxisNameProperty, value); }
        }

        public double SetPosition
        {
            get { return (double)GetValue(SetPositionProperty); }
            set { SetValue(SetPositionProperty, value); }
        }

        public double SetVelocity
        {
            get { return (double)GetValue(SetVelocityProperty); }
            set { SetValue(SetVelocityProperty, value); }
        }

        public double ActualPosition
        {
            get { return (double)GetValue(ActualPositionProperty); }
            set { SetValue(ActualPositionProperty, value); }
        }

        public double ActualVelocity
        {
            get { return (double)GetValue(ActualVelocityProperty); }
            set { SetValue(ActualVelocityProperty, value); }
        }

        public double TargetPosition
        {
            get { return (double)GetValue(TargetPositionProperty); }
            set { SetValue(TargetPositionProperty, value); }
        }

        public double TargetVelocity
        {
            get { return (double)GetValue(TargetVelocityProperty); }
            set { SetValue(TargetVelocityProperty, value); }
        }

        public double TargetAcceleration
        {
            get { return (double)GetValue(TargetAccelerationProperty); }
            set { SetValue(TargetAccelerationProperty, value); }
        }

        public double TargetDeceleration
        {
            get { return (double)GetValue(TargetDecelerationProperty); }
            set { SetValue(TargetDecelerationProperty, value); }
        }

        private void TextEditTargetPosition_KeyDown(object sender, KeyEventArgs e)
        {  

        }

        private void TargetPositionValueChanged_Event(object sender, EditValueChangingEventArgs e)
        {
            TargetPositionValueChanged?.Invoke(this, e);
        }

        private void TargetVelocityValueChanged_Event(object sender, EditValueChangingEventArgs e)
        {
            TargetVelocityValueChanged?.Invoke(this, e);
        }


        private void TextEditTargetVelocity_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextEditTargetAcceleration_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextEditTargetDeceleration_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
