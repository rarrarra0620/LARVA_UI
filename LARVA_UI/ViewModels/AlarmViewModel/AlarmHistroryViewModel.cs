using DevExpress.Mvvm.CodeGenerators;
using EPLE.Core.Manager.Model;
using EPLE.Core.Manager;
using LARVA_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using System.Windows;
using System.Windows.Media;
using System.ComponentModel;
using DevExpress.Xpf.Editors;
using EPLE.Core;
using System.Data;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class AlarmHistroryViewModel
    {
        private DateTime startDateTime;
        private DateTime endDateTime;
        public DelegateCommand<RoutedEventArgs> SearchAlarmHistoryCommand { get; private set; }
        public DelegateCommand<RoutedEventArgs> StartEditValueChangedCommand { get; private set; }
        public DelegateCommand<RoutedEventArgs> EndEditValueChangedCommand { get; private set; }

        public ObservableCollection<AlarmHistoryDisplay> alarmHistoryList;
        public AlarmHistroryViewModel()
        {
            Initialize();
        }

        public ObservableCollection<AlarmHistoryDisplay> AlarmHistoryList
        {
            get { return alarmHistoryList; }
            set
            {
                if (alarmHistoryList != value)
                {
                    alarmHistoryList = value;
                    OnPropertyChanged("AlarmHistoryList");
                }
            }
        }

        public DateTime StartDateTime
        {
            get { return startDateTime; }
            set
            {
                startDateTime = value;
                OnPropertyChanged(nameof(StartDateTime));
            }
        }

        public DateTime EndDateTime
        {
            get { return endDateTime; }
            set
            {
                endDateTime = value;
                OnPropertyChanged(nameof(EndDateTime));
            }
        }

        private void Initialize()
        {
            alarmHistoryList = new ObservableCollection<AlarmHistoryDisplay>();
            SearchAlarmHistoryCommand = new DelegateCommand<RoutedEventArgs>(ExecuteSearchAlarmHistoryComamnd);
            StartEditValueChangedCommand = new DelegateCommand<RoutedEventArgs>(ExecuteStartEditValueChangedCommand);
            EndEditValueChangedCommand = new DelegateCommand<RoutedEventArgs>(ExecuteEndEditValueChangedCommand);

            var CnvSTime = DateTime.Now.AddDays(-1);
            StartDateTime = new DateTime(CnvSTime.Year, CnvSTime.Month, CnvSTime.Day, CnvSTime.Hour, 0, 0);
            EndDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            AlarmDBSearch_Click();
        }

        private void ExecuteEndEditValueChangedCommand(RoutedEventArgs args)
        {

        }

        private void ExecuteStartEditValueChangedCommand(RoutedEventArgs args)
        {
            
        }

        private void ExecuteSearchAlarmHistoryComamnd(RoutedEventArgs args)
        {
            AlarmDBSearch_Click();
        }


        private void AlarmDBSearch_Click()
        {
            try
            {

                DateTime start_date = StartDateTime;
                DateTime end_date = EndDateTime;


                if (start_date > end_date)
                {
                    MessageBox.Show("Start date can not be equal or greater...");
                }
                else
                {
                    //CurrentAlarm.Clear();
                    DataTable alarmHistData = AlarmManager.Instance.GetAlarmHistory(start_date, end_date);

<<<<<<< Updated upstream
                    // DataTable 내림차순 정렬 ( 기준 : EVENTTIME Column )
                    //alarmHistData.DefaultView.Sort = "UPDATETIME DESC";
=======
                    // DataTable 내림차순 정렬 ( 기준 : EVENTTIME Column ) 

                    if (alarmHistData == null)
                        return;

                    alarmHistData.DefaultView.Sort = "UPDATETIME DESC";
>>>>>>> Stashed changes
                    alarmHistData = alarmHistData.DefaultView.ToTable(true);

                    AlarmHistoryList.Clear();
                    foreach (DataRow dr in alarmHistData.Rows)
                    {
                        AlarmHistoryList.Add(new AlarmHistoryDisplay()
                        {
                            ID = dr["ID"].ToString(),
                            LEVEL = dr["LEVEL"].ToString(),
                            TEXT = dr["TEXT"].ToString(),
                            STATUS = dr["STATUS"].ToString(),
                            DESCRIPTION = dr["DESCRIPTION"].ToString(),
                            UPDATETIME = DateTime.Parse(dr["UPDATETIME"].ToString())
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
