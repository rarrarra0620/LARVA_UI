using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using DevExpress.Map.Kml.Model;
using DevExpress.Mvvm;

namespace LARVA_UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand MainViewClicked { get; private set; }
        public ICommand SettingsViewClicked { get; private set; }
        public ICommand AlarmViewClicked { get; private set; }
        public MainWindowViewModel()
        {
            MainViewClicked = new DelegateCommand(OnMainViewClicked);
            SettingsViewClicked = new DelegateCommand(OnSettingsViewClicked);
            AlarmViewClicked = new DelegateCommand(OnAlarmViewClicked);
        }

        private void OnMainViewClicked()
        {

        }

        private void OnSettingsViewClicked()
        {

        }

        private void OnAlarmViewClicked()
        {

        }
    }
}
