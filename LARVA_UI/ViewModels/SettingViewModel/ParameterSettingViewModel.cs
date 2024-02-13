using DevExpress.Mvvm.CodeGenerators;
using EPLE.App;
using EPLE.IO;
using System.ComponentModel;
using System.Windows;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class ParameterSettingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [GenerateProperty]
        private int flipImpactDuration;
        [GenerateProperty]
        private int flipOutConveyorDuration;
        [GenerateProperty]
        private int flipSwingDuration;
        [GenerateProperty]
        private int tobbabSupplyWeight;
        [GenerateProperty]
        private int tobbabSupplyTimeout;
        [GenerateProperty]
        private int washingDurationTime;
        [GenerateProperty]
        private int mistSupplyDuration;
        [GenerateProperty]
        private double hvacTargetTemperature;
        [GenerateProperty]
        private double hvacTargetHumidity;

        public ParameterSettingViewModel()
        {

        }

        [GenerateCommand]
        private void FlipImpactDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nBoxImpact_Duration, FlipImpactDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nBoxImpact_Duration, FlipImpactDuration);
        }

        [GenerateCommand]
        private void FlipOutConveyorDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nOutConv_Duration, FlipOutConveyorDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nOutConv_Duration, FlipOutConveyorDuration);
        }

        [GenerateCommand]
        private void FlipSwingDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nFlipSwing_Duration, FlipSwingDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nFlipSwing_Duration, FlipSwingDuration);
        }

        [GenerateCommand]
        private void TobbabSupplyWeightSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTobbab_Weight, TobbabSupplyWeight);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nTobbab_Weight, TobbabSupplyWeight);
        }

        [GenerateCommand]
        private void TobbabSupplyTimeoutSetClick(RoutedEventArgs args)
        {

        }

        [GenerateCommand]
        private void WashingDurationTimeSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nWash_Duration, WashingDurationTime);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nWash_Duration, WashingDurationTime);
        }

        [GenerateCommand]
        private void MistSupplyDurationSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nMist_Duration, MistSupplyDuration);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_nMist_Duration, MistSupplyDuration);
        }

        [GenerateCommand]
        private void HvacTargetTemperatureSetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_fHvac_TargetTemp, HvacTargetTemperature);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_fHvac_TargetTemp, HvacTargetTemperature);
        }

        [GenerateCommand]
        private void HvacTargetHumiditySetClick(RoutedEventArgs args)
        {
            DataManager.Instance.SET_DOUBLE_DATA(IoNameHelper.oParam_fHvac_TargetHumidity, HvacTargetHumidity);
            DataManager.Instance.CHANGE_DEFAULT_DATA(IoNameHelper.oParam_fHvac_TargetHumidity, HvacTargetHumidity);
        }

    }
}
