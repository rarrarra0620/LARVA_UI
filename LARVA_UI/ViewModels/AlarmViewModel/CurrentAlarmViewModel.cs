using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.App;
using EPLE.Core;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using EPLE.IO;
using LARVA_UI.Models;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class CurrentAlarmViewModel
    {
        //public DelegateCommand<RoutedEventArgs> AlarmResetTouchDownCommand;
        //public DelegateCommand<RoutedEventArgs> AlarmResetTouchUpCommand;
        //public DelegateCommand<RoutedEventArgs> AlarmResetButtonDownCommand;
        //public DelegateCommand<RoutedEventArgs> AlarmResetButtonUpCommand;

        //public DelegateCommand<RoutedEventArgs> BuzzerOffTouchDownCommand;
        //public DelegateCommand<RoutedEventArgs> BuzzerOffTouchUpCommand;
        //public DelegateCommand<RoutedEventArgs> BuzzerOffButtonDownCommand;
        //public DelegateCommand<RoutedEventArgs> BuzzerOffButtonUpCommand;

        private ObservableCollection<CurrentAlarmDisplay> _CurrentAlarmList;
        public CurrentAlarmViewModel()
        {
            Initialize();

            AlarmManager.Instance.SetAlarmEvent += SetAlarmEvent;
            AlarmManager.Instance.ResetAlarmEvent += ResetAlarmEvent;
        }

        public ObservableCollection<CurrentAlarmDisplay> CurrentAlarmList
        {
            get { return _CurrentAlarmList; }
            set
            {
                if (_CurrentAlarmList != value)
                {
                    _CurrentAlarmList = value;
                    OnPropertyChanged("CurrentAlarmList");
                }
            }
        }

        public void SetAlarmEvent(object sender, EventArgs e)
        {
            UpdateCurrentAlarmDisplay();
        }

        public void ResetAlarmEvent(object sender, EventArgs e)
        {
            UpdateCurrentAlarmDisplay();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Initialize()
        {
            //AlarmResetTouchDownCommand = new DelegateCommand<RoutedEventArgs>(ExecuteAlarmResetButtonDownCommand);
            //AlarmResetTouchUpCommand = new DelegateCommand<RoutedEventArgs>(ExecuteAlarmResetButtonUpCommand);
            //AlarmResetButtonDownCommand = new DelegateCommand<RoutedEventArgs>(ExecuteAlarmResetButtonDownCommand);
            //AlarmResetButtonUpCommand = new DelegateCommand<RoutedEventArgs>(ExecuteAlarmResetButtonUpCommand);
            //BuzzerOffTouchDownCommand = new DelegateCommand<RoutedEventArgs>(ExecuteBuzzerOffButtonDownCommand);
            //BuzzerOffTouchUpCommand = new DelegateCommand<RoutedEventArgs>(ExecuteBuzzerOffButtonUpCommand);
            //BuzzerOffButtonDownCommand = new DelegateCommand<RoutedEventArgs>(ExecuteBuzzerOffButtonDownCommand);
            //BuzzerOffButtonUpCommand = new DelegateCommand<RoutedEventArgs>(ExecuteBuzzerOffButtonUpCommand);
            _CurrentAlarmList = new ObservableCollection<CurrentAlarmDisplay>();

            UpdateCurrentAlarmDisplay();
        }

        [GenerateCommand]
        private void AlarmResetButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, false);
        }

        [GenerateCommand]
        private void AlarmResetButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nAlarm_Reset, true);
        }

        [GenerateCommand]
        private void BuzzerOffButtonUp(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, false);
        }

        [GenerateCommand]
        private void BuzzerOffButtonDown(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oEqp_nBuzzer_Off, true);
        }

        private void UpdateCurrentAlarmDisplay()
        {
            List<ALARM> currentAlarmList = AlarmManager.Instance.GetCurrentAlarmAsList();
            ObservableCollection<CurrentAlarmDisplay> currentAlarmDisplays = new ObservableCollection<CurrentAlarmDisplay>();

            foreach (var alarm in currentAlarmList)
            {
                if (alarm != null)
                {
                    bool alarmValue = DataManager.Instance.GET_BOOL_DATA(String.Format("iAlarm.{0}", alarm.ID), out bool result);

                    if (result && !alarmValue)
                    {
                        AlarmManager.Instance.ResetAlarm(alarm.ID);
                        continue;
                    }

                    currentAlarmDisplays.Add(new CurrentAlarmDisplay()
                    {
                        ID = alarm.ID,
                        NAME = alarm.TEXT,
                        DESCRIPTION = alarm.DESCRIPTION,
                        LEVEL = alarm.LEVEL.ToString(),
                        SETTIME = alarm.SETTIME,
                    });
                }
                else
                {
                    continue;
                }
            }

            CurrentAlarmList = currentAlarmDisplays;
        }
    }
}
