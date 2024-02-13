using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.App;
using EPLE.Core.Manager;
using EPLE.IO;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class MainViewModel : INotifyPropertyChanged
    {
        [GenerateProperty]
        string _Status;
        [GenerateProperty]
        string _UserName;

        [GenerateCommand]
        void Login() => Status = "User: " + UserName;
        bool CanLogin() => !string.IsNullOrEmpty(UserName);

        //public DelegateCommand<RoutedEventArgs> ModeChangeCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> BuzzerOffCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> AlarmResetCommand { get; private set; }

        //public DelegateCommand<RoutedEventArgs> BuzzerOffTouchDownCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> BuzzerOffTouchUpCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> AlarmResetTouchDownCommand { get; private set; }
        //public DelegateCommand<RoutedEventArgs> AlarmResetTouchUpCommand { get; private set; }

        public string _modeTxt {  get; private set; }

        public string ModeTxt
        {
            get { return _modeTxt; }
            set
            {
                _modeTxt = value;
                OnPropertyChanged(nameof(ModeTxt));
            }
        }
        public MainViewModel()
        {
            //ModeChangeCommand = new DelegateCommand<RoutedEventArgs>(ModeChangeCommandExecute);
            //BuzzerOffCommand = new DelegateCommand<RoutedEventArgs>(BuzzerOffComamndExecute);
            //AlarmResetCommand = new DelegateCommand<RoutedEventArgs>(AlarmResetCommandExecute);
            //BuzzerOffTouchDownCommand = new DelegateCommand<RoutedEventArgs>(BuzzerOffTouchDownCommandExecute);
            //BuzzerOffTouchUpCommand = new DelegateCommand<RoutedEventArgs>(BuzzerOffTouchUpCommandExecute);
            //AlarmResetTouchDownCommand = new DelegateCommand<RoutedEventArgs>(AlarmResetTouchDownCommandExecute);
            //AlarmResetTouchUpCommand = new DelegateCommand<RoutedEventArgs>(AlarmResetTouchUpCommandExecute);

            DataManager.Instance.DataAccess.DataChangedEvent += new EventHandler<DataChangedEventHandlerArgs>(OnDataChanged);
            int nMode = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out bool result);
           

            if (result)
            {
                switch(nMode)
                {
                    case (int)eAccessMode.MANUAL:
                        {
                            ModeTxt = "MANUAL";
                        }
                        break;
                    case (int)eAccessMode.AUTO:
                        {
                            ModeTxt = "AUTO";
                        }
                        break;
                    default:
                        {
                            ModeTxt = "NONE";
                        }
                        break;

                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnDataChanged(object sender, DataChangedEventHandlerArgs e)
        {
            Data data = (Data)e.Data;

            if (Application.Current == null) return;

            Application.Current.Dispatcher.Invoke(() =>
            {
                if (data.Name == IoNameHelper.iEqp_nOp_Mode)
                {
                    if (Convert.ToInt32(data.Value) == (int)eAccessMode.AUTO)
                    {
                        ModeTxt = "AUTO";
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eAccessMode.MANUAL)
                    {
                        ModeTxt = "MANUAL";
                    }
                }
            }
            );
        }
        [GenerateCommand]
        private void ModeChange(RoutedEventArgs args)
        {
            int tmp = 0;
            tmp = DataManager.Instance.GET_INT_DATA(IoNameHelper.iEqp_nOp_Mode, out bool result);
            if (tmp == (int)eAccessMode.MANUAL)
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oEqp_nOp_Mode, (int)eAccessMode.AUTO);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oEqp_nOp_Mode, (int)eAccessMode.MANUAL);
            }
        }
        [GenerateCommand]
        private void AlarmResetTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, false);
        }

        [GenerateCommand]
        private void AlarmResetTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, true);
            AlarmManager.Instance.ResetAlarmAll();
        }

        [GenerateCommand]
        private void BuzzerOffTouchUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, false);
        }

        [GenerateCommand]
        private void BuzzerOffTouchDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, true);
        }

        [GenerateCommand]
        private void AlarmReset(RoutedEventArgs args)
        {
            if (args is MouseEventArgs)
            {
                MouseEventArgs mouseEventArgs = (MouseEventArgs)args;

                if (mouseEventArgs.LeftButton == MouseButtonState.Pressed)
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, true);
                }
                else
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, false);
                }
            }
        }

        [GenerateCommand]
        private void BuzzerOff(RoutedEventArgs args)
        {
            if (args is MouseEventArgs)
            {
                MouseEventArgs mouseEventArgs = (MouseEventArgs)args;

                if (mouseEventArgs.LeftButton == MouseButtonState.Pressed)
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, true);
                }
                else
                {
                    DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, false);
                }
            }
        }

        public void MainContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
