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
        public DelegateCommand<RoutedEventArgs> UpperCoverCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> ImpactCylinderCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> OutConveyorCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> FlipOutShutterCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> HoperMotorCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> HotAirBlowerCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> UVLampCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> MistCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> TbsShutterCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> FlatMotorCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> SwingCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> MixerCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> WaterTankValveCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> WashWaterCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> WaterPumpCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> ZoneCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> FloorCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> RowCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> RackCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> CirculatorCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> AmmoniaCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> TRSHandCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> TRSClampCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> TRSCoverCommandClicked { get; private set; }
        public DelegateCommand<RoutedEventArgs> TRSCoverVacCommandClicked { get; private set; }

        [GenerateProperty]
        private SolidColorBrush loaderShutterOpenBG;

        [GenerateProperty]
        private SolidColorBrush loaderShutterCloseBG;

        private SolidColorBrush _loaderShuttleFWBG;
        private SolidColorBrush _loaderShuttleBWBG;
        private SolidColorBrush _upperCoverUpBG;
        private SolidColorBrush _upperCoverDnBG;
        private SolidColorBrush _impactCylinderOnBG;
        private SolidColorBrush _impactCylinderOffBG;
        private SolidColorBrush _outConveyorOnBG;  //out io get
        private SolidColorBrush _outConveyorOffBG;
        private SolidColorBrush _flipOutShutterOpenBG;
        private SolidColorBrush _flipOutShutterCloseBG;
        private SolidColorBrush _hoperMotorOnBG; //out io get
        private SolidColorBrush _hoperMotorOffBG;
        private SolidColorBrush _hotAirBlowerOnBG;  //out io get
        private SolidColorBrush _hotAirBlowerOffBG;
        private SolidColorBrush _uVLampOnBG;  //out io get
        private SolidColorBrush _uVLampOffBG;

        private SolidColorBrush _mistOnBG;
        private SolidColorBrush _mistOffBG;
        private SolidColorBrush _tbsShutterOpenBG;
        private SolidColorBrush _tbsShutterCloseBG;
        private SolidColorBrush _flatMotorOnBG;
        private SolidColorBrush _flatMotorOffBG;
        private SolidColorBrush _swingOnBG;
        private SolidColorBrush _swingOffBG;
        private SolidColorBrush _mixerOnBG;
        private SolidColorBrush _mixerOffBG;
        private SolidColorBrush _waterTankValveOpenBG;
        private SolidColorBrush _waterTankValveCloseBG;
        private SolidColorBrush _washWaterOpenBG;
        private SolidColorBrush _washWaterCloseBG;
        private SolidColorBrush _waterPumpOpenBG;
        private SolidColorBrush _waterPumpCloseBG;
        private SolidColorBrush _zone1BG;
        private SolidColorBrush _zone2BG;
        private SolidColorBrush _zone3BG;
        private SolidColorBrush _zone4BG;
        private SolidColorBrush _zone5BG;
        private SolidColorBrush _zone6BG;
        private SolidColorBrush _zone7BG;
        private SolidColorBrush _zone8BG;
        private SolidColorBrush _floor1BG;
        private SolidColorBrush _floor2BG;
        private SolidColorBrush _floor3BG;
        private SolidColorBrush _floor4BG;
        private SolidColorBrush _floor5BG;
        private SolidColorBrush _row1BG;
        private SolidColorBrush _row2BG;
        private SolidColorBrush _row3BG;
        private SolidColorBrush _rackMoveBG;
        private SolidColorBrush _rackLoadingBG;
        private SolidColorBrush _rackUnloadingBG;
        private SolidColorBrush _tRSHandLeftBG;
        private SolidColorBrush _tRSHandRightBG;
        private SolidColorBrush _tRSClampOpenBG;
        private SolidColorBrush _tRSClampCloseBG;
        private SolidColorBrush _tRSCoverUpBG;
        private SolidColorBrush _tRSCoverDnBG;
        private SolidColorBrush _tRSCoverVacOnBG;
        private SolidColorBrush _tRSCoverOffBG;
        private SolidColorBrush _circulatorOnBG;
        private SolidColorBrush _circulatorOffBG;
        private SolidColorBrush _ammoniaOnBG;
        private SolidColorBrush _ammoniaOffBG;

        public SolidColorBrush MistOnBG
        {
            get { return _mistOnBG; }
            set
            {
                _mistOnBG = value;
                OnPropertyChanged(nameof(MistOnBG));
            }
        }
        public SolidColorBrush MistOffBG
        {
            get { return _mistOffBG; }
            set
            {
                _mistOffBG = value;
                OnPropertyChanged(nameof(MistOffBG));
            }
        }
        public SolidColorBrush TbsShutterOpenBG
        {
            get { return _tbsShutterOpenBG; }
            set
            {
                _tbsShutterOpenBG = value;
                OnPropertyChanged(nameof(TbsShutterOpenBG));
            }
        }
        public SolidColorBrush TbsShutterCloseBG
        {
            get { return _tbsShutterCloseBG; }
            set
            {
                _tbsShutterCloseBG = value;
                OnPropertyChanged(nameof(TbsShutterCloseBG));
            }
        }
        public SolidColorBrush FlatMotorOnBG
        {
            get { return _flatMotorOnBG; }
            set
            {
                _flatMotorOnBG = value;
                OnPropertyChanged(nameof(FlatMotorOnBG));
            }
        }
        public SolidColorBrush FlatMotorOffBG
        {
            get { return _flatMotorOffBG; }
            set
            {
                _flatMotorOffBG = value;
                OnPropertyChanged(nameof(FlatMotorOffBG));
            }
        }
        public SolidColorBrush SwingOnBG
        {
            get { return _swingOnBG; }
            set
            {
                _swingOnBG = value;
                OnPropertyChanged(nameof(SwingOnBG));
            }
        }
        public SolidColorBrush SwingOffBG
        {
            get { return _swingOffBG; }
            set
            {
                _swingOffBG = value;
                OnPropertyChanged(nameof(SwingOffBG));
            }
        }
        public SolidColorBrush MixerOnBG
        {
            get { return _mixerOnBG; }
            set
            {
                _mixerOnBG = value;
                OnPropertyChanged(nameof(MixerOnBG));
            }
        }
        public SolidColorBrush MixerOffBG
        {
            get { return _mixerOffBG; }
            set
            {
                _mixerOffBG = value;
                OnPropertyChanged(nameof(MixerOffBG));
            }
        }
        public SolidColorBrush WaterTankValveOpenBG
        {
            get { return _waterTankValveOpenBG; }
            set
            {
                _waterTankValveOpenBG = value;
                OnPropertyChanged(nameof(WaterTankValveOpenBG));
            }
        }
        public SolidColorBrush WaterTankValveCloseBG
        {
            get { return _waterTankValveCloseBG; }
            set
            {
                _waterTankValveCloseBG = value;
                OnPropertyChanged(nameof(WaterTankValveCloseBG));
            }
        }
        public SolidColorBrush WashWaterOpenBG
        {
            get { return _washWaterOpenBG; }
            set
            {
                _washWaterOpenBG = value;
                OnPropertyChanged(nameof(WashWaterOpenBG));
            }
        }
        public SolidColorBrush WashWaterCloseBG
        {
            get { return _washWaterCloseBG; }
            set
            {
                _washWaterCloseBG = value;
                OnPropertyChanged(nameof(WashWaterCloseBG));
            }
        }
        public SolidColorBrush WaterPumpOpenBG
        {
            get { return _waterPumpOpenBG; }
            set
            {
                _waterPumpOpenBG = value;
                OnPropertyChanged(nameof(WaterPumpOpenBG));
            }
        }
        public SolidColorBrush WaterPumpCloseBG
        {
            get { return _waterPumpCloseBG; }
            set
            {
                _waterPumpCloseBG = value;
                OnPropertyChanged(nameof(WaterPumpCloseBG));
            }
        }
        
        public SolidColorBrush Zone1BG
        {
            get { return _zone1BG; }
            set
            {
                _zone1BG = value;
                OnPropertyChanged(nameof(Zone1BG));
            }
        }
        public SolidColorBrush Zone2BG
        {
            get { return _zone2BG; }
            set
            {
                _zone2BG = value;
                OnPropertyChanged(nameof(Zone2BG));
            }
        }
        public SolidColorBrush Zone3BG
        {
            get { return _zone3BG; }
            set
            {
                _zone3BG = value;
                OnPropertyChanged(nameof(Zone3BG));
            }
        }
        public SolidColorBrush Zone4BG
        {
            get { return _zone4BG; }
            set
            {
                _zone4BG = value;
                OnPropertyChanged(nameof(Zone4BG));
            }
        }
        public SolidColorBrush Zone5BG
        {
            get { return _zone5BG; }
            set
            {
                _zone5BG = value;
                OnPropertyChanged(nameof(Zone5BG));
            }
        }
        public SolidColorBrush Zone6BG
        {
            get { return _zone6BG; }
            set
            {
                _zone6BG = value;
                OnPropertyChanged(nameof(Zone6BG));
            }
        }
        public SolidColorBrush Zone7BG
        {
            get { return _zone7BG; }
            set
            {
                _zone7BG = value;
                OnPropertyChanged(nameof(Zone7BG));
            }
        }
        public SolidColorBrush Zone8BG
        {
            get { return _zone8BG; }
            set
            {
                _zone8BG = value;
                OnPropertyChanged(nameof(Zone8BG));
            }
        }
        public SolidColorBrush Floor1BG
        {
            get { return _floor1BG; }
            set
            {
                _floor1BG = value;
                OnPropertyChanged(nameof(Floor1BG));
            }
        }
        public SolidColorBrush Floor2BG
        {
            get { return _floor2BG; }
            set
            {
                _floor2BG = value;
                OnPropertyChanged(nameof(Floor2BG));
            }
        }
        public SolidColorBrush Floor3BG
        {
            get { return _floor3BG; }
            set
            {
                _floor3BG = value;
                OnPropertyChanged(nameof(Floor3BG));
            }
        }
        public SolidColorBrush Floor4BG
        {
            get { return _floor4BG; }
            set
            {
                _floor4BG = value;
                OnPropertyChanged(nameof(Floor4BG));
            }
        }
        public SolidColorBrush Floor5BG
        {
            get { return _floor5BG; }
            set
            {
                _floor5BG = value;
                OnPropertyChanged(nameof(Floor5BG));
            }
        }
        public SolidColorBrush Row1BG
        {
            get { return _row1BG; }
            set
            {
                _row1BG = value;
                OnPropertyChanged(nameof(Row1BG));
            }
        }
        public SolidColorBrush Row2BG
        {
            get { return _row2BG; }
            set
            {
                _row2BG = value;
                OnPropertyChanged(nameof(Row2BG));
            }
        }
        public SolidColorBrush Row3BG
        {
            get { return _row3BG; }
            set
            {
                _row3BG = value;
                OnPropertyChanged(nameof(Row3BG));
            }
        }
        public SolidColorBrush RackMoveBG
        {
            get { return _rackMoveBG; }
            set
            {
                _rackMoveBG = value;
                OnPropertyChanged(nameof(RackMoveBG));
            }
        }
        public SolidColorBrush RackLoadingBG
        {
            get { return _rackLoadingBG; }
            set
            {
                _rackLoadingBG = value;
                OnPropertyChanged(nameof(RackLoadingBG));
            }
        }
        public SolidColorBrush RackUnloadingBG
        {
            get { return _rackUnloadingBG; }
            set
            {
                _rackUnloadingBG = value;
                OnPropertyChanged(nameof(RackUnloadingBG));
            }
        }
        public SolidColorBrush TRSHandLeftBG
        {
            get { return _tRSHandLeftBG; }
            set
            {
                _tRSHandLeftBG = value;
                OnPropertyChanged(nameof(TRSHandLeftBG));
            }
        }
        public SolidColorBrush TRSHandRightBG
        {
            get { return _tRSHandRightBG; }
            set
            {
                _tRSHandRightBG = value;
                OnPropertyChanged(nameof(TRSHandRightBG));
            }
        }
        public SolidColorBrush TRSClampOpenBG
        {
            get { return _tRSClampOpenBG; }
            set
            {
                _tRSClampOpenBG = value;
                OnPropertyChanged(nameof(TRSClampOpenBG));
            }
        }
        public SolidColorBrush TRSClampCloseBG
        {
            get { return _tRSClampCloseBG; }
            set
            {
                _tRSClampCloseBG = value;
                OnPropertyChanged(nameof(TRSClampCloseBG));
            }
        }
        public SolidColorBrush TRSCoverUpBG
        {
            get { return _tRSCoverUpBG; }
            set
            {
                _tRSCoverUpBG = value;
                OnPropertyChanged(nameof(TRSCoverUpBG));
            }
        }
        public SolidColorBrush TRSCoverDnBG
        {
            get { return _tRSCoverDnBG; }
            set
            {
                _tRSCoverDnBG = value;
                OnPropertyChanged(nameof(TRSCoverDnBG));
            }
        }
        public SolidColorBrush TRSCoverVacOnBG
        {
            get { return _tRSCoverVacOnBG; }
            set
            {
                _tRSCoverVacOnBG = value;
                OnPropertyChanged(nameof(TRSCoverVacOnBG));
            }
        }
        public SolidColorBrush TRSCoverOffBG
        {
            get { return _tRSCoverOffBG; }
            set
            {
                _tRSCoverOffBG = value;
                OnPropertyChanged(nameof(TRSCoverOffBG));
            }
        }
        public SolidColorBrush CirculatorOnBG
        {
            get { return _circulatorOnBG; }
            set
            {
                _circulatorOnBG = value;
                OnPropertyChanged(nameof(CirculatorOnBG));
            }
        }
        public SolidColorBrush CirculatorOffBG
        {
            get { return _circulatorOffBG; }
            set
            {
                _circulatorOffBG = value;
                OnPropertyChanged(nameof(CirculatorOffBG));
            }
        }
        public SolidColorBrush AmmoniaOnBG
        {
            get { return _ammoniaOnBG; }
            set
            {
                _ammoniaOnBG = value;
                OnPropertyChanged(nameof(AmmoniaOnBG));
            }
        }
        public SolidColorBrush AmmoniaOffBG
        {
            get { return _ammoniaOffBG; }
            set
            {
                _ammoniaOffBG = value;
                OnPropertyChanged(nameof(AmmoniaOffBG));
            }
        }

        public SolidColorBrush LoaderShuttleFWBG
        {
            get { return _loaderShuttleFWBG; }
            set
            {
                _loaderShuttleFWBG = value;
                OnPropertyChanged(nameof(LoaderShuttleFWBG));
            }
        }
        public SolidColorBrush LoaderShuttleBWBG
        {
            get { return _loaderShuttleBWBG; }
            set
            {
                _loaderShuttleBWBG = value;
                OnPropertyChanged(nameof(LoaderShuttleBWBG));
            }
        }
        public SolidColorBrush UpperCoverUpBG
        {
            get { return _upperCoverUpBG; }
            set
            {
                _upperCoverUpBG = value;
                OnPropertyChanged(nameof(UpperCoverUpBG));
            }
        }
        public SolidColorBrush UpperCoverDnBG
        {
            get { return _upperCoverDnBG; }
            set
            {
                _upperCoverDnBG = value;
                OnPropertyChanged(nameof(UpperCoverDnBG));
            }
        }
        public SolidColorBrush ImpactCylinderOnBG
        {
            get { return _impactCylinderOnBG; }
            set
            {
                _impactCylinderOnBG = value;
                OnPropertyChanged(nameof(ImpactCylinderOnBG));
            }
        }
        public SolidColorBrush ImpactCylinderOffBG
        {
            get { return _impactCylinderOffBG; }
            set
            {
                _impactCylinderOffBG = value;
                OnPropertyChanged(nameof(ImpactCylinderOffBG));
            }
        }
        public SolidColorBrush OutConveyorOnBG
        {
            get { return _outConveyorOnBG; }
            set
            {
                _outConveyorOnBG = value;
                OnPropertyChanged(nameof(OutConveyorOnBG));
            }
        }
        public SolidColorBrush OutConveyorOffBG
        {
            get { return _outConveyorOffBG; }
            set
            {
                _outConveyorOffBG = value;
                OnPropertyChanged(nameof(OutConveyorOffBG));
            }
        }
        public SolidColorBrush FlipOutShutterOpenBG
        {
            get { return _flipOutShutterOpenBG; }
            set
            {
                _flipOutShutterOpenBG = value;
                OnPropertyChanged(nameof(FlipOutShutterOpenBG));
            }
        }
        public SolidColorBrush FlipOutShutterCloseBG
        {
            get { return _flipOutShutterCloseBG; }
            set
            {
                _flipOutShutterCloseBG = value;
                OnPropertyChanged(nameof(FlipOutShutterCloseBG));
            }
        }
        public SolidColorBrush HoperMotorOnBG
        {
            get { return _hoperMotorOnBG; }
            set
            {
                _hoperMotorOnBG = value;
                OnPropertyChanged(nameof(HoperMotorOnBG));
            }
        }
        public SolidColorBrush HoperMotorOffBG
        {
            get { return _hoperMotorOffBG; }
            set
            {
                _hoperMotorOffBG = value;
                OnPropertyChanged(nameof(HoperMotorOffBG));
            }
        }
        public SolidColorBrush HotAirBlowerOnBG
        {
            get { return _hotAirBlowerOnBG; }
            set
            {
                _hotAirBlowerOnBG = value;
                OnPropertyChanged(nameof(HotAirBlowerOnBG));
            }
        }
        public SolidColorBrush HotAirBlowerOffBG
        {
            get { return _hotAirBlowerOffBG; }
            set
            {
                _hotAirBlowerOffBG = value;
                OnPropertyChanged(nameof(HotAirBlowerOffBG));
            }
        }
        public SolidColorBrush UVLampOnBG
        {
            get { return _uVLampOnBG; }
            set
            {
                _uVLampOnBG = value;
                OnPropertyChanged(nameof(UVLampOnBG));
            }
        }
        public SolidColorBrush UVLampOffBG
        {
            get { return _uVLampOffBG; }
            set
            {
                _uVLampOffBG = value;
                OnPropertyChanged(nameof(UVLampOffBG));
            }
        }

        public ManualViewModel()
        {
            //LoaderShutterCommandClicked = new DelegateCommand<RoutedEventArgs>(LoaderShutterCommand);
            //LoaderShuttleCommandClicked = new DelegateCommand<RoutedEventArgs>(LoaderShuttleCommand);
            UpperCoverCommandClicked = new DelegateCommand<RoutedEventArgs>(UpperCoverCommand);
            ImpactCylinderCommandClicked = new DelegateCommand<RoutedEventArgs>(ImpactCylinderCommand);
            OutConveyorCommandClicked = new DelegateCommand<RoutedEventArgs>(OutConveyorCommand);
            FlipOutShutterCommandClicked = new DelegateCommand<RoutedEventArgs>(FlipOutShutterCommand);
            HoperMotorCommandClicked = new DelegateCommand<RoutedEventArgs>(HoperMotorCommand);
            HotAirBlowerCommandClicked = new DelegateCommand<RoutedEventArgs>(HotAirBlowerCommand);
            UVLampCommandClicked = new DelegateCommand<RoutedEventArgs>(UVLampCommand);
            MistCommandClicked = new DelegateCommand<RoutedEventArgs>(MistCommand);
            TbsShutterCommandClicked = new DelegateCommand<RoutedEventArgs>(TbsShutterCommand);
            FlatMotorCommandClicked = new DelegateCommand<RoutedEventArgs>(FlatMotorCommand);
            SwingCommandClicked = new DelegateCommand<RoutedEventArgs>(SwingCommand);
            MixerCommandClicked = new DelegateCommand<RoutedEventArgs>(MixerCommand);
            WaterTankValveCommandClicked = new DelegateCommand<RoutedEventArgs>(WaterTankValveCommand);
            WashWaterCommandClicked = new DelegateCommand<RoutedEventArgs>(WashWaterCommand);
            WaterPumpCommandClicked = new DelegateCommand<RoutedEventArgs>(WaterPumpCommand);
            ZoneCommandClicked = new DelegateCommand<RoutedEventArgs>(ZoneCommand);
            FloorCommandClicked = new DelegateCommand<RoutedEventArgs>(FloorCommand);
            RowCommandClicked = new DelegateCommand<RoutedEventArgs>(RowCommand);
            RackCommandClicked = new DelegateCommand<RoutedEventArgs>(RackCommand);
            CirculatorCommandClicked = new DelegateCommand<RoutedEventArgs>(CirculatorCommand);
            AmmoniaCommandClicked = new DelegateCommand<RoutedEventArgs>(AmmoniaCommand);
            TRSHandCommandClicked = new DelegateCommand<RoutedEventArgs>(TRSHandCommand);
            TRSClampCommandClicked = new DelegateCommand<RoutedEventArgs>(TRSClampCommand);
            TRSCoverCommandClicked = new DelegateCommand<RoutedEventArgs>(TRSCoverCommand);
            TRSCoverVacCommandClicked = new DelegateCommand<RoutedEventArgs>(TRSCoverVacCommand);


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
