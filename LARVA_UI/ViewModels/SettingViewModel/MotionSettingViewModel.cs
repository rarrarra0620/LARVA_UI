using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.App;
using EPLE.IO;
using System;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class MotionSettingViewModel : ViewModelBase
    {

        public MotionSettingViewModel()
        {

        }

        public int ID { get; set; }

        //public string ServoAxisName { get { return _servoAxisName; } set { _servoAxisName = value; RaisePropertyChanged("ServoAxisName"); } }
        //public bool IsEnabledServo { get { return _isEnabled; } set { _isEnabled = value; RaisePropertyChanged("IsEnabledServo"); } }
    }
}
