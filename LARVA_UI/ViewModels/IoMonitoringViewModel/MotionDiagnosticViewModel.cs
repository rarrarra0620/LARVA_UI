using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.App;
using EPLE.IO;
using System;

namespace LARVA_UI.ViewModels
{
    public partial class MotionDiagnosticViewModel : ViewModelBase
    {
        private System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        private string axisControllerOverride = "";
        private string setVelocity;

        public MotionDiagnosticViewModel()
        {

        }

        public string AxisControllerOverride { get { return axisControllerOverride; } set { axisControllerOverride = value; RaisePropertyChanged("AxisControllerOverride"); } }
        public string SetVelocity { get { return setVelocity; } set {  setVelocity = value; RaisePropertyChanged("SetVelocity"); } }
    }
}
