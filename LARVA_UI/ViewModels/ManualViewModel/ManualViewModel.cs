using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using System;
using System.Windows;
using EPLE.IO;
using EPLE.App;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Media;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class ManualViewModel
    {
        //public DelegateCommand<RoutedEventArgs> LoaderShutterCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> LoaderShuttleCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> UpperCoverCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> ImpactCylinderCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> OutConveyorCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> FlipOutShutterCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> HoperMotorCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> HotAirBlowerCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> UVLampCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> MistCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> TbsShutterCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> FlatMotorCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> SwingCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> MixerCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> WaterTankValveCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> WashWaterCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> WaterPumpCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> ZoneCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> FloorCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> RowCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> RackCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> CirculatorCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> AmmoniaCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> TRSHandCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> TRSClampCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> TRSCoverCommandClicked { get; private set; }
        //public DelegateCommand<RoutedEventArgs> TRSCoverVacCommandClicked { get; private set; }

        [GenerateProperty]
        private SolidColorBrush loaderShutterOpenBG;
        [GenerateProperty]
        private SolidColorBrush loaderShutterCloseBG;
        [GenerateProperty]
        private SolidColorBrush loaderShuttleFWBG;
        [GenerateProperty]
        private SolidColorBrush loaderShuttleBWBG;
        [GenerateProperty]
        private SolidColorBrush upperCoverUpBG;
        [GenerateProperty]
        private SolidColorBrush upperCoverDnBG;
        [GenerateProperty]
        private SolidColorBrush impactCylinderOnBG;
        [GenerateProperty]
        private SolidColorBrush impactCylinderOffBG;
        [GenerateProperty]
        private SolidColorBrush outConveyorOnBG;  //out io get
        [GenerateProperty]
        private SolidColorBrush outConveyorOffBG;
        [GenerateProperty]
        private SolidColorBrush flipOutShutterOpenBG;
        [GenerateProperty]
        private SolidColorBrush flipOutShutterCloseBG;
        [GenerateProperty]
        private SolidColorBrush hoperMotorOnBG; //out io get
        [GenerateProperty]
        private SolidColorBrush hoperMotorOffBG;
        [GenerateProperty]
        private SolidColorBrush hotAirBlowerOnBG;  //out io get
        [GenerateProperty]
        private SolidColorBrush hotAirBlowerOffBG;
        [GenerateProperty]
        private SolidColorBrush uVLampOnBG;  //out io get
        [GenerateProperty]
        private SolidColorBrush uVLampOffBG;
        [GenerateProperty]
        private SolidColorBrush mistOnBG;
        [GenerateProperty]
        private SolidColorBrush mistOffBG;
        [GenerateProperty]
        private SolidColorBrush tbsShutterOpenBG;
        [GenerateProperty]
        private SolidColorBrush tbsShutterCloseBG;
        [GenerateProperty]
        private SolidColorBrush flatMotorOnBG;
        [GenerateProperty]
        private SolidColorBrush flatMotorOffBG;
        [GenerateProperty]
        private SolidColorBrush swingOnBG;
        [GenerateProperty]
        private SolidColorBrush swingOffBG;
        [GenerateProperty]
        private SolidColorBrush mixerOnBG;
        [GenerateProperty]
        private SolidColorBrush mixerOffBG;
        [GenerateProperty]
        private SolidColorBrush waterTankValveOpenBG;
        [GenerateProperty]
        private SolidColorBrush waterTankValveCloseBG;
        [GenerateProperty]
        private SolidColorBrush washWaterOpenBG;
        [GenerateProperty]
        private SolidColorBrush washWaterCloseBG;
        [GenerateProperty]
        private SolidColorBrush waterPumpOpenBG;
        [GenerateProperty]
        private SolidColorBrush waterPumpCloseBG;
        [GenerateProperty]
        private SolidColorBrush zone1BG;
        [GenerateProperty]
        private SolidColorBrush zone2BG;
        [GenerateProperty]
        private SolidColorBrush zone3BG;
        [GenerateProperty]
        private SolidColorBrush zone4BG;
        [GenerateProperty]
        private SolidColorBrush zone5BG;
        [GenerateProperty]
        private SolidColorBrush zone6BG;
        [GenerateProperty]
        private SolidColorBrush zone7BG;
        [GenerateProperty]
        private SolidColorBrush zone8BG;
        [GenerateProperty]
        private SolidColorBrush floor1BG;
        [GenerateProperty]
        private SolidColorBrush floor2BG;
        [GenerateProperty]
        private SolidColorBrush floor3BG;
        [GenerateProperty]
        private SolidColorBrush floor4BG;
        [GenerateProperty]
        private SolidColorBrush floor5BG;
        [GenerateProperty]
        private SolidColorBrush row1BG;
        [GenerateProperty]
        private SolidColorBrush row2BG;
        [GenerateProperty]
        private SolidColorBrush row3BG;
        [GenerateProperty]
        private SolidColorBrush rackMoveBG;
        [GenerateProperty]
        private SolidColorBrush rackLoadingBG;
        [GenerateProperty]
        private SolidColorBrush rackUnloadingBG;
        [GenerateProperty]
        private SolidColorBrush tRSHandLeftBG;
        [GenerateProperty]
        private SolidColorBrush tRSHandRightBG;
        [GenerateProperty]
        private SolidColorBrush tRSClampOpenBG;
        [GenerateProperty]
        private SolidColorBrush tRSClampCloseBG;
        [GenerateProperty]
        private SolidColorBrush tRSCoverUpBG;
        [GenerateProperty]
        private SolidColorBrush tRSCoverDnBG;
        [GenerateProperty]
        private SolidColorBrush tRSCoverVacOnBG;
        [GenerateProperty]
        private SolidColorBrush tRSCoverOffBG;
        [GenerateProperty]
        private SolidColorBrush circulatorOnBG;
        [GenerateProperty]
        private SolidColorBrush circulatorOffBG;
        [GenerateProperty]
        private SolidColorBrush ammoniaOnBG;
        [GenerateProperty]
        private SolidColorBrush ammoniaOffBG;


        //public SolidColorBrush MistOnBG
        //{
        //    get { return mistOnBG; }
        //    set
        //    {
        //        mistOnBG = value;
        //        OnPropertyChanged(nameof(MistOnBG));
        //    }
        //}
        //public SolidColorBrush MistOffBG
        //{
        //    get { return mistOffBG; }
        //    set
        //    {
        //        mistOffBG = value;
        //        OnPropertyChanged(nameof(MistOffBG));
        //    }
        //}
        //public SolidColorBrush TbsShutterOpenBG
        //{
        //    get { return tbsShutterOpenBG; }
        //    set
        //    {
        //        tbsShutterOpenBG = value;
        //        OnPropertyChanged(nameof(TbsShutterOpenBG));
        //    }
        //}
        //public SolidColorBrush TbsShutterCloseBG
        //{
        //    get { return tbsShutterCloseBG; }
        //    set
        //    {
        //        tbsShutterCloseBG = value;
        //        OnPropertyChanged(nameof(TbsShutterCloseBG));
        //    }
        //}
        //public SolidColorBrush FlatMotorOnBG
        //{
        //    get { return flatMotorOnBG; }
        //    set
        //    {
        //        flatMotorOnBG = value;
        //        OnPropertyChanged(nameof(FlatMotorOnBG));
        //    }
        //}
        //public SolidColorBrush FlatMotorOffBG
        //{
        //    get { return flatMotorOffBG; }
        //    set
        //    {
        //        flatMotorOffBG = value;
        //        OnPropertyChanged(nameof(FlatMotorOffBG));
        //    }
        //}
        //public SolidColorBrush SwingOnBG
        //{
        //    get { return swingOnBG; }
        //    set
        //    {
        //        swingOnBG = value;
        //        OnPropertyChanged(nameof(SwingOnBG));
        //    }
        //}
        //public SolidColorBrush SwingOffBG
        //{
        //    get { return swingOffBG; }
        //    set
        //    {
        //        swingOffBG = value;
        //        OnPropertyChanged(nameof(SwingOffBG));
        //    }
        //}
        //public SolidColorBrush MixerOnBG
        //{
        //    get { return mixerOnBG; }
        //    set
        //    {
        //        mixerOnBG = value;
        //        OnPropertyChanged(nameof(MixerOnBG));
        //    }
        //}
        //public SolidColorBrush MixerOffBG
        //{
        //    get { return mixerOffBG; }
        //    set
        //    {
        //        mixerOffBG = value;
        //        OnPropertyChanged(nameof(MixerOffBG));
        //    }
        //}
        //public SolidColorBrush WaterTankValveOpenBG
        //{
        //    get { return waterTankValveOpenBG; }
        //    set
        //    {
        //        waterTankValveOpenBG = value;
        //        OnPropertyChanged(nameof(WaterTankValveOpenBG));
        //    }
        //}
        //public SolidColorBrush WaterTankValveCloseBG
        //{
        //    get { return waterTankValveCloseBG; }
        //    set
        //    {
        //        waterTankValveCloseBG = value;
        //        OnPropertyChanged(nameof(WaterTankValveCloseBG));
        //    }
        //}
        //public SolidColorBrush WashWaterOpenBG
        //{
        //    get { return washWaterOpenBG; }
        //    set
        //    {
        //        washWaterOpenBG = value;
        //        OnPropertyChanged(nameof(WashWaterOpenBG));
        //    }
        //}
        //public SolidColorBrush WashWaterCloseBG
        //{
        //    get { return washWaterCloseBG; }
        //    set
        //    {
        //        washWaterCloseBG = value;
        //        OnPropertyChanged(nameof(WashWaterCloseBG));
        //    }
        //}
        //public SolidColorBrush WaterPumpOpenBG
        //{
        //    get { return waterPumpOpenBG; }
        //    set
        //    {
        //        waterPumpOpenBG = value;
        //        OnPropertyChanged(nameof(WaterPumpOpenBG));
        //    }
        //}
        //public SolidColorBrush WaterPumpCloseBG
        //{
        //    get { return waterPumpCloseBG; }
        //    set
        //    {
        //        waterPumpCloseBG = value;
        //        OnPropertyChanged(nameof(WaterPumpCloseBG));
        //    }
        //}
        
        //public SolidColorBrush Zone1BG
        //{
        //    get { return zone1BG; }
        //    set
        //    {
        //        zone1BG = value;
        //        OnPropertyChanged(nameof(Zone1BG));
        //    }
        //}
        //public SolidColorBrush Zone2BG
        //{
        //    get { return zone2BG; }
        //    set
        //    {
        //        zone2BG = value;
        //        OnPropertyChanged(nameof(Zone2BG));
        //    }
        //}
        //public SolidColorBrush Zone3BG
        //{
        //    get { return zone3BG; }
        //    set
        //    {
        //        zone3BG = value;
        //        OnPropertyChanged(nameof(Zone3BG));
        //    }
        //}
        //public SolidColorBrush Zone4BG
        //{
        //    get { return zone4BG; }
        //    set
        //    {
        //        zone4BG = value;
        //        OnPropertyChanged(nameof(Zone4BG));
        //    }
        //}
        //public SolidColorBrush Zone5BG
        //{
        //    get { return zone5BG; }
        //    set
        //    {
        //        zone5BG = value;
        //        OnPropertyChanged(nameof(Zone5BG));
        //    }
        //}
        //public SolidColorBrush Zone6BG
        //{
        //    get { return zone6BG; }
        //    set
        //    {
        //        zone6BG = value;
        //        OnPropertyChanged(nameof(Zone6BG));
        //    }
        //}
        //public SolidColorBrush Zone7BG
        //{
        //    get { return zone7BG; }
        //    set
        //    {
        //        zone7BG = value;
        //        OnPropertyChanged(nameof(Zone7BG));
        //    }
        //}
        //public SolidColorBrush Zone8BG
        //{
        //    get { return zone8BG; }
        //    set
        //    {
        //        zone8BG = value;
        //        OnPropertyChanged(nameof(Zone8BG));
        //    }
        //}
        //public SolidColorBrush Floor1BG
        //{
        //    get { return floor1BG; }
        //    set
        //    {
        //        floor1BG = value;
        //        OnPropertyChanged(nameof(Floor1BG));
        //    }
        //}
        //public SolidColorBrush Floor2BG
        //{
        //    get { return floor2BG; }
        //    set
        //    {
        //        floor2BG = value;
        //        OnPropertyChanged(nameof(Floor2BG));
        //    }
        //}
        //public SolidColorBrush Floor3BG
        //{
        //    get { return floor3BG; }
        //    set
        //    {
        //        floor3BG = value;
        //        OnPropertyChanged(nameof(Floor3BG));
        //    }
        //}
        //public SolidColorBrush Floor4BG
        //{
        //    get { return floor4BG; }
        //    set
        //    {
        //        floor4BG = value;
        //        OnPropertyChanged(nameof(Floor4BG));
        //    }
        //}
        //public SolidColorBrush Floor5BG
        //{
        //    get { return floor5BG; }
        //    set
        //    {
        //        floor5BG = value;
        //        OnPropertyChanged(nameof(Floor5BG));
        //    }
        //}
        //public SolidColorBrush Row1BG
        //{
        //    get { return row1BG; }
        //    set
        //    {
        //        row1BG = value;
        //        OnPropertyChanged(nameof(Row1BG));
        //    }
        //}
        //public SolidColorBrush Row2BG
        //{
        //    get { return row2BG; }
        //    set
        //    {
        //        row2BG = value;
        //        OnPropertyChanged(nameof(Row2BG));
        //    }
        //}
        //public SolidColorBrush Row3BG
        //{
        //    get { return row3BG; }
        //    set
        //    {
        //        row3BG = value;
        //        OnPropertyChanged(nameof(Row3BG));
        //    }
        //}
        //public SolidColorBrush RackMoveBG
        //{
        //    get { return rackMoveBG; }
        //    set
        //    {
        //        rackMoveBG = value;
        //        OnPropertyChanged(nameof(RackMoveBG));
        //    }
        //}
        //public SolidColorBrush RackLoadingBG
        //{
        //    get { return rackLoadingBG; }
        //    set
        //    {
        //        rackLoadingBG = value;
        //        OnPropertyChanged(nameof(RackLoadingBG));
        //    }
        //}
        //public SolidColorBrush RackUnloadingBG
        //{
        //    get { return rackUnloadingBG; }
        //    set
        //    {
        //        rackUnloadingBG = value;
        //        OnPropertyChanged(nameof(RackUnloadingBG));
        //    }
        //}
        //public SolidColorBrush TRSHandLeftBG
        //{
        //    get { return tRSHandLeftBG; }
        //    set
        //    {
        //        tRSHandLeftBG = value;
        //        OnPropertyChanged(nameof(TRSHandLeftBG));
        //    }
        //}
        //public SolidColorBrush TRSHandRightBG
        //{
        //    get { return tRSHandRightBG; }
        //    set
        //    {
        //        tRSHandRightBG = value;
        //        OnPropertyChanged(nameof(TRSHandRightBG));
        //    }
        //}
        //public SolidColorBrush TRSClampOpenBG
        //{
        //    get { return tRSClampOpenBG; }
        //    set
        //    {
        //        tRSClampOpenBG = value;
        //        OnPropertyChanged(nameof(TRSClampOpenBG));
        //    }
        //}
        //public SolidColorBrush TRSClampCloseBG
        //{
        //    get { return tRSClampCloseBG; }
        //    set
        //    {
        //        tRSClampCloseBG = value;
        //        OnPropertyChanged(nameof(TRSClampCloseBG));
        //    }
        //}
        //public SolidColorBrush TRSCoverUpBG
        //{
        //    get { return tRSCoverUpBG; }
        //    set
        //    {
        //        tRSCoverUpBG = value;
        //        OnPropertyChanged(nameof(TRSCoverUpBG));
        //    }
        //}
        //public SolidColorBrush TRSCoverDnBG
        //{
        //    get { return tRSCoverDnBG; }
        //    set
        //    {
        //        tRSCoverDnBG = value;
        //        OnPropertyChanged(nameof(TRSCoverDnBG));
        //    }
        //}
        //public SolidColorBrush TRSCoverVacOnBG
        //{
        //    get { return tRSCoverVacOnBG; }
        //    set
        //    {
        //        tRSCoverVacOnBG = value;
        //        OnPropertyChanged(nameof(TRSCoverVacOnBG));
        //    }
        //}
        //public SolidColorBrush TRSCoverOffBG
        //{
        //    get { return tRSCoverOffBG; }
        //    set
        //    {
        //        tRSCoverOffBG = value;
        //        OnPropertyChanged(nameof(TRSCoverOffBG));
        //    }
        //}
        //public SolidColorBrush CirculatorOnBG
        //{
        //    get { return circulatorOnBG; }
        //    set
        //    {
        //        circulatorOnBG = value;
        //        OnPropertyChanged(nameof(CirculatorOnBG));
        //    }
        //}
        //public SolidColorBrush CirculatorOffBG
        //{
        //    get { return circulatorOffBG; }
        //    set
        //    {
        //        circulatorOffBG = value;
        //        OnPropertyChanged(nameof(CirculatorOffBG));
        //    }
        //}
        //public SolidColorBrush AmmoniaOnBG
        //{
        //    get { return ammoniaOnBG; }
        //    set
        //    {
        //        ammoniaOnBG = value;
        //        OnPropertyChanged(nameof(AmmoniaOnBG));
        //    }
        //}
        //public SolidColorBrush AmmoniaOffBG
        //{
        //    get { return ammoniaOffBG; }
        //    set
        //    {
        //        ammoniaOffBG = value;
        //        OnPropertyChanged(nameof(AmmoniaOffBG));
        //    }
        //}

        //public SolidColorBrush LoaderShuttleFWBG
        //{
        //    get { return loaderShuttleFWBG; }
        //    set
        //    {
        //        loaderShuttleFWBG = value;
        //        OnPropertyChanged(nameof(LoaderShuttleFWBG));
        //    }
        //}
        //public SolidColorBrush LoaderShuttleBWBG
        //{
        //    get { return loaderShuttleBWBG; }
        //    set
        //    {
        //        loaderShuttleBWBG = value;
        //        OnPropertyChanged(nameof(LoaderShuttleBWBG));
        //    }
        //}
        //public SolidColorBrush UpperCoverUpBG
        //{
        //    get { return upperCoverUpBG; }
        //    set
        //    {
        //        upperCoverUpBG = value;
        //        OnPropertyChanged(nameof(UpperCoverUpBG));
        //    }
        //}
        //public SolidColorBrush UpperCoverDnBG
        //{
        //    get { return upperCoverDnBG; }
        //    set
        //    {
        //        upperCoverDnBG = value;
        //        OnPropertyChanged(nameof(UpperCoverDnBG));
        //    }
        //}
        //public SolidColorBrush ImpactCylinderOnBG
        //{
        //    get { return impactCylinderOnBG; }
        //    set
        //    {
        //        impactCylinderOnBG = value;
        //        OnPropertyChanged(nameof(ImpactCylinderOnBG));
        //    }
        //}
        //public SolidColorBrush ImpactCylinderOffBG
        //{
        //    get { return impactCylinderOffBG; }
        //    set
        //    {
        //        impactCylinderOffBG = value;
        //        OnPropertyChanged(nameof(ImpactCylinderOffBG));
        //    }
        //}
        //public SolidColorBrush OutConveyorOnBG
        //{
        //    get { return outConveyorOnBG; }
        //    set
        //    {
        //        outConveyorOnBG = value;
        //        OnPropertyChanged(nameof(OutConveyorOnBG));
        //    }
        //}
        //public SolidColorBrush OutConveyorOffBG
        //{
        //    get { return outConveyorOffBG; }
        //    set
        //    {
        //        outConveyorOffBG = value;
        //        OnPropertyChanged(nameof(OutConveyorOffBG));
        //    }
        //}
        //public SolidColorBrush FlipOutShutterOpenBG
        //{
        //    get { return flipOutShutterOpenBG; }
        //    set
        //    {
        //        flipOutShutterOpenBG = value;
        //        OnPropertyChanged(nameof(FlipOutShutterOpenBG));
        //    }
        //}
        //public SolidColorBrush FlipOutShutterCloseBG
        //{
        //    get { return flipOutShutterCloseBG; }
        //    set
        //    {
        //        flipOutShutterCloseBG = value;
        //        OnPropertyChanged(nameof(FlipOutShutterCloseBG));
        //    }
        //}
        //public SolidColorBrush HoperMotorOnBG
        //{
        //    get { return hoperMotorOnBG; }
        //    set
        //    {
        //        hoperMotorOnBG = value;
        //        OnPropertyChanged(nameof(HoperMotorOnBG));
        //    }
        //}
        //public SolidColorBrush HoperMotorOffBG
        //{
        //    get { return hoperMotorOffBG; }
        //    set
        //    {
        //        hoperMotorOffBG = value;
        //        OnPropertyChanged(nameof(HoperMotorOffBG));
        //    }
        //}
        //public SolidColorBrush HotAirBlowerOnBG
        //{
        //    get { return hotAirBlowerOnBG; }
        //    set
        //    {
        //        hotAirBlowerOnBG = value;
        //        OnPropertyChanged(nameof(HotAirBlowerOnBG));
        //    }
        //}
        //public SolidColorBrush HotAirBlowerOffBG
        //{
        //    get { return hotAirBlowerOffBG; }
        //    set
        //    {
        //        hotAirBlowerOffBG = value;
        //        OnPropertyChanged(nameof(HotAirBlowerOffBG));
        //    }
        //}
        //public SolidColorBrush UVLampOnBG
        //{
        //    get { return uVLampOnBG; }
        //    set
        //    {
        //        uVLampOnBG = value;
        //        OnPropertyChanged(nameof(UVLampOnBG));
        //    }
        //}
        //public SolidColorBrush UVLampOffBG
        //{
        //    get { return uVLampOffBG; }
        //    set
        //    {
        //        uVLampOffBG = value;
        //        OnPropertyChanged(nameof(UVLampOffBG));
        //    }
        //}

        public ManualViewModel()
        {
            //LoaderShutterCommandClicked = new DelegateCommand<RoutedEventArgs>(LoaderShutterCommand);
            //LoaderShuttleCommandClicked = new DelegateCommand<RoutedEventArgs>(LoaderShuttleCommand);
            //UpperCoverCommandClicked = new DelegateCommand<RoutedEventArgs>(UpperCoverCommand);
            //ImpactCylinderCommandClicked = new DelegateCommand<RoutedEventArgs>(ImpactCylinderCommand);
            //OutConveyorCommandClicked = new DelegateCommand<RoutedEventArgs>(OutConveyorCommand);
            //FlipOutShutterCommandClicked = new DelegateCommand<RoutedEventArgs>(FlipOutShutterCommand);
            //HoperMotorCommandClicked = new DelegateCommand<RoutedEventArgs>(HoperMotorCommand);
            //HotAirBlowerCommandClicked = new DelegateCommand<RoutedEventArgs>(HotAirBlowerCommand);
            //UVLampCommandClicked = new DelegateCommand<RoutedEventArgs>(UVLampCommand);
            //MistCommandClicked = new DelegateCommand<RoutedEventArgs>(MistCommand);
            //TbsShutterCommandClicked = new DelegateCommand<RoutedEventArgs>(TbsShutterCommand);
            //FlatMotorCommandClicked = new DelegateCommand<RoutedEventArgs>(FlatMotorCommand);
            //SwingCommandClicked = new DelegateCommand<RoutedEventArgs>(SwingCommand);
            //MixerCommandClicked = new DelegateCommand<RoutedEventArgs>(MixerCommand);
            //WaterTankValveCommandClicked = new DelegateCommand<RoutedEventArgs>(WaterTankValveCommand);
            //WashWaterCommandClicked = new DelegateCommand<RoutedEventArgs>(WashWaterCommand);
            //WaterPumpCommandClicked = new DelegateCommand<RoutedEventArgs>(WaterPumpCommand);
            //ZoneCommandClicked = new DelegateCommand<RoutedEventArgs>(ZoneCommand);
            //FloorCommandClicked = new DelegateCommand<RoutedEventArgs>(FloorCommand);
            //RowCommandClicked = new DelegateCommand<RoutedEventArgs>(RowCommand);
            //RackCommandClicked = new DelegateCommand<RoutedEventArgs>(RackCommand);
            //CirculatorCommandClicked = new DelegateCommand<RoutedEventArgs>(CirculatorCommand);
            //AmmoniaCommandClicked = new DelegateCommand<RoutedEventArgs>(AmmoniaCommand);
            //TRSHandCommandClicked = new DelegateCommand<RoutedEventArgs>(TRSHandCommand);
            //TRSClampCommandClicked = new DelegateCommand<RoutedEventArgs>(TRSClampCommand);
            //TRSCoverCommandClicked = new DelegateCommand<RoutedEventArgs>(TRSCoverCommand);
            //TRSCoverVacCommandClicked = new DelegateCommand<RoutedEventArgs>(TRSCoverVacCommand);


            DataManager.Instance.DataAccess.DataChangedEvent += new EventHandler<DataChangedEventHandlerArgs>(OnDataChanged);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnDataChanged(object sender, DataChangedEventHandlerArgs e)
        {
            int tmp;
            bool result;
            tmp = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, out result);

            Data data = (Data)e.Data;

            if (Application.Current == null) return; 

            Application.Current.Dispatcher.Invoke(() =>
            {
                if (tmp == (int)eOnOff.OFF || tmp == (int)eOnOff.ON)
                {
                    if (tmp == (int)eOnOff.ON)
                    {
                        OutConveyorOnBG = new SolidColorBrush(Colors.LightGreen);
                        OutConveyorOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (tmp == (int)eOnOff.OFF)
                    {
                        OutConveyorOnBG = new SolidColorBrush(Colors.Transparent);
                        OutConveyorOffBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        OutConveyorOnBG = new SolidColorBrush(Colors.Transparent);
                        OutConveyorOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                if (data.Name == IoNameHelper.iLoader_nShutter_UpDown)
                {
                    if (Convert.ToInt32(data.Value) == (int)eUpDown.DOWN)
                    {
                        LoaderShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
                        LoaderShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eUpDown.UP)
                    {
                        LoaderShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        LoaderShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        LoaderShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        LoaderShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iLoader_nShuttle_FwdBwd)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        LoaderShuttleFWBG = new SolidColorBrush(Colors.LightGreen);
                        LoaderShuttleBWBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        LoaderShuttleFWBG = new SolidColorBrush(Colors.Transparent);
                        LoaderShuttleBWBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        LoaderShuttleFWBG = new SolidColorBrush(Colors.Transparent);
                        LoaderShuttleBWBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iFlip_nUpperCover_UpDown)
                {
                    if (Convert.ToInt32(data.Value) == (int)eUpDown.UP)
                    {
                        UpperCoverUpBG = new SolidColorBrush(Colors.LightGreen);
                        UpperCoverDnBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eUpDown.DOWN)
                    {
                        UpperCoverUpBG = new SolidColorBrush(Colors.Transparent);
                        UpperCoverDnBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        UpperCoverUpBG = new SolidColorBrush(Colors.Transparent);
                        UpperCoverDnBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.oFlip_nBoxImpact_RunStop)
                {
                    if (Convert.ToInt32(data.Value) == (int)eRunStop.RUN)
                    {
                        ImpactCylinderOnBG = new SolidColorBrush(Colors.LightGreen);
                        ImpactCylinderOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eRunStop.STOP)
                    {
                        ImpactCylinderOnBG = new SolidColorBrush(Colors.Transparent);
                        ImpactCylinderOffBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        ImpactCylinderOnBG = new SolidColorBrush(Colors.Transparent);
                        ImpactCylinderOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iFlip_nOutShutter_UpDown)
                {
                    if (Convert.ToInt32(data.Value) == (int)eUpDown.UP)
                    {
                        FlipOutShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
                        FlipOutShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eUpDown.DOWN)
                    {
                        FlipOutShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        FlipOutShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        FlipOutShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        FlipOutShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTBS_nFlatCyl_FwdBwd)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        TbsShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
                        TbsShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        TbsShutterOpenBG =  new SolidColorBrush(Colors.Transparent);
                        TbsShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TbsShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        TbsShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTBS_nSwingCyl_FwdBwd)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        SwingOnBG = new SolidColorBrush(Colors.LightGreen);
                        SwingOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        SwingOnBG = new SolidColorBrush(Colors.Transparent);
                        SwingOffBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        SwingOnBG = new SolidColorBrush(Colors.Transparent);
                        SwingOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTrans_nHandLeft_FwdBwd)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        TRSHandLeftBG = new SolidColorBrush(Colors.LightGreen);
                        TRSHandRightBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        TRSHandLeftBG = new SolidColorBrush(Colors.Transparent);
                        TRSHandRightBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TRSHandLeftBG = new SolidColorBrush(Colors.Transparent);
                        TRSHandRightBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTrans_nClamp_LockUnlock)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        TRSClampCloseBG = new SolidColorBrush(Colors.LightGreen);
                        TRSClampOpenBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        TRSClampCloseBG= new SolidColorBrush(Colors.Transparent);
                        TRSClampOpenBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TRSClampCloseBG= new SolidColorBrush(Colors.Transparent);
                        TRSClampOpenBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTrans_nBoxCover_UpDown)
                {
                    if (Convert.ToInt32(data.Value) == (int)eUpDown.UP)
                    {
                        TRSCoverUpBG = new SolidColorBrush(Colors.LightGreen);
                        TRSCoverDnBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eUpDown.DOWN)
                    {
                        TRSCoverUpBG  = new SolidColorBrush(Colors.Transparent);
                        TRSCoverDnBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TRSCoverUpBG  = new SolidColorBrush(Colors.Transparent);
                        TRSCoverDnBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTrans_nBoxCoverVac_OnOff)
                {
                    if (Convert.ToInt32(data.Value) == (int)eOnOff.ON)
                    {
                        TRSCoverVacOnBG = new SolidColorBrush(Colors.LightGreen);
                        TRSCoverOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eOnOff.OFF)
                    {
                        TRSCoverVacOnBG = new SolidColorBrush(Colors.Transparent);
                        TRSCoverOffBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TRSCoverVacOnBG = new SolidColorBrush(Colors.Transparent);
                        TRSCoverOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
            });
        }
        private void MistCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMist_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMist_OnOff, (int)eOnOff.OFF);
            }
        }
        private void TbsShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatCyl_RunStop, (int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatCyl_RunStop, (int)eRunStop.STOP);
            }
        }
        private void FlatMotorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatMotor_RunStop, (int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatMotor_RunStop, (int)eRunStop.STOP);
            }
        }
        private void SwingCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nSwingCyl_RunStop, (int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nSwingCyl_RunStop, (int)eRunStop.STOP);
            }
        }
        private void MixerCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMixer_Motor, (int)eMotorCmd.CW);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, (int)eMotorCmd.OFF);
            }
        }
        private void WaterTankValveCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nTankValve_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nTankValve_OnOff, (int)eOnOff.OFF);
            }
        }
        private void WashWaterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, (int)eOnOff.OFF);
            }
        }
        private void WaterPumpCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterPump_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterPump_OnOff, (int)eOnOff.OFF);
            }
        }
        private void ZoneCommand(RoutedEventArgs args)
        {
            //
        }
        private void FloorCommand(RoutedEventArgs args)
        {
            //
        }
        private void RowCommand(RoutedEventArgs args)
        {
            //
        }
        private void RackCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("이동"))
            {
            }
            else if (((ContentControl)args.OriginalSource).Content.ToString().Equals("로딩"))
            {
            }
            else if (((ContentControl)args.OriginalSource).Content.ToString().Equals("언로딩"))
            {
            }
            else
            {
            }
        }
        private void CirculatorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAir_nCirculatorFan_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAir_nCirculatorFan_OnOff, (int)eOnOff.OFF);
            }
        }
        private void AmmoniaCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAmmo_nExhaustFan_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAmmo_nExhaustFan_OnOff, (int)eOnOff.OFF);
            }
        }
        private void TRSHandCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("왼쪽"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eFwdBwd.BACKWARD);
            }
        }
        private void TRSClampCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_BoxClamp_LockUnlock, (int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_BoxClamp_LockUnlock, (int)eFwdBwd.BACKWARD);
            }
        }
        private void TRSCoverCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("위로"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxCover_UpDown, (int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxCover_UpDown, (int)eUpDown.DOWN);
            }
        }
        private void TRSCoverVacCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("흡착"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVac_OnOff, (int)eOnOff.ON);
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.OFF);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVac_OnOff, (int)eOnOff.OFF);
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.ON);
            }
        }
        private void UVLampCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("켜짐"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nUVLamp_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nUVLamp_OnOff, (int)eOnOff.OFF);
            }
        }

        private void HotAirBlowerCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("켜짐"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oHotAir_nBlower_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oHotAir_nBlower_OnOff, (int)eOnOff.OFF);
            }
        }

        private void HoperMotorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nHopper_Motor, (int)eMotorCmd.CW);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nHopper_Motor, (int)eMotorCmd.OFF);
            }
        }

        private void FlipOutShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutShutter_UpDown, (int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutShutter_UpDown, (int)eUpDown.DOWN);
            }
        }

        private void OutConveyorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "구동")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, (int)eOnOff.OFF);
            }
        }

        private void ImpactCylinderCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "구동")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nBoxImpact_RunStop, (int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nBoxImpact_RunStop, (int)eRunStop.STOP);
            }
        }

        private void UpperCoverCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "위로")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nUpperCover_UpDown, (int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nUpperCover_UpDown, (int)eUpDown.DOWN);
            }

        }

        [GenerateCommand(Name = "LoaderShuttleCommandClicked")]
        private void LoaderShuttleCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("전진"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShuttle_FwdBwd, (int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShuttle_FwdBwd, (int)eFwdBwd.BACKWARD);
            }
        }

        [GenerateCommand(Name = "LoaderShutterCommandClicked")]
        private void LoaderShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShutter_UpDown, (int)eUpDown.DOWN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShutter_UpDown, (int)eUpDown.UP);
            }
        }
    }
}
