using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Xpf.PivotGrid.Printing.TypedStyles;
using EPLE.App;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using EPLE.IO;
using LARVA_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class TeachingViewModel : INotifyPropertyChanged
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
        private List<string> transferHandItems = new List<string>();
        [GenerateProperty]
        private List<string> locationTypeItems = new List<string>();

        [GenerateProperty]
        private long selectedLocationIndex;

        [GenerateProperty]
        private double teaching_X_Position;
        [GenerateProperty]
        private double teaching_Y_In_Position;
        [GenerateProperty]
        private double teaching_Y_Out_Position;
        [GenerateProperty]
        private double teaching_Z_Up_Position;
        [GenerateProperty]
        private double teaching_Z_Down_Position;
        [GenerateProperty]
        private string teaching_Transfer_Hand;
        [GenerateProperty]
        private string teaching_Location_Type;
        [GenerateProperty]
        private double actual_X_Position;
        [GenerateProperty]
        private double actual_Y_Position;
        [GenerateProperty]
        private double actual_Z_Position;


        public ObservableCollection<string> LocationItems { get; set; }

        public TeachingViewModel()
        {
            Initialize();
            UpdateLocationItems();


        }

        private void Initialize()
        {
            bool result = false;
            double dVal;

            DataManager.Instance.DataAccess.DataChangedEvent += DataChanged;

            selectedLocationIndex = 0;

            dVal = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iXAxis_dAct_Pos, out result);
            if (result)
                Actual_X_Position = dVal;
            else
                Actual_X_Position = 0.0;

            dVal = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iYAxis_dAct_Pos, out result);
            if (result)
                Actual_Y_Position = dVal;
            else
                Actual_Y_Position = 0.0;

            dVal = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iZAxis_dAct_Pos, out result);
            if (result)
                Actual_Z_Position = dVal;
            else
                Actual_Z_Position = 0.0;

            transferHandItems.Add("LEFT");
            transferHandItems.Add("RIGHT");

            locationTypeItems.Add("PROCESS");
            locationTypeItems.Add("STOCKER");
            locationTypeItems.Add("LD/ULD");
            locationTypeItems.Add("BUFFER");
        }

        private void DataChanged(object sender, DataChangedEventHandlerArgs e)
        {
            Data data = (Data)e.Data;

            switch (data.Name)
            {
                case "iXAxis.dAct.Pos":
                    Actual_X_Position = (double)data.Value;
                    break;
                case "iYAxis.dAct.Pos":
                    Actual_Y_Position = (double)data.Value;
                    break;
                case "iZAxis.dAct.Pos":
                    Actual_Z_Position = (double)data.Value;
                    break;
            }
        }

        private void UpdateLocationTeachingData(long locationId)
        {
            LOCATION_INFO info = LocationManager.Instance.GetLocationList().Find((item) => { return item.LOCATION_ID == locationId; });

            Teaching_X_Position = info.X_POS;
            Teaching_Y_In_Position = info.Y_IN_POS;
            Teaching_Y_Out_Position = info.Y_OUT_POS;
            Teaching_Z_Up_Position = info.Z_UP_POS;
            Teaching_Z_Down_Position = info.Z_DOWN_POS;
            Teaching_Transfer_Hand = info.TRANSFER_HAND;
            Teaching_Location_Type = info.LOCATION_TYPE;
        }

        public void UpdateLocationItems()
        {
            LocationItems = new ObservableCollection<string>();
            List<string> keys = LocationManager.Instance.GetLocationKeys();

            foreach (string item in keys)
            {
                LocationItems.Add(item);
            }
        }



        [GenerateCommand]
        private void SelectionChanged(RoutedEventArgs args)
        {
            SelectionChangedEventArgs eventArgs = args as SelectionChangedEventArgs;

            if (eventArgs != null)
            {
                char[] sep = { ':' };
                string[] arrStr = eventArgs.AddedItems[0].ToString().Split(sep);
                selectedLocationIndex = long.Parse(arrStr[0]);

                UpdateLocationTeachingData(selectedLocationIndex);
            }

        }

        [GenerateCommand]
        private void TeachingXPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateXPosition(selectedLocationIndex, Actual_X_Position);
            UpdateLocationTeachingData(selectedLocationIndex);
            SetXPosition((int)selectedLocationIndex, Teaching_X_Position, true);
        }

        [GenerateCommand]
        private void TeachingYInPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateYInPosition(selectedLocationIndex, Actual_Y_Position);
            UpdateLocationTeachingData(selectedLocationIndex);
            SetYInPosition((int)selectedLocationIndex, Teaching_Y_In_Position, true);
        }

        [GenerateCommand]
        private void TeachingYOutPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateYOutPosition(selectedLocationIndex, Actual_Y_Position);
            UpdateLocationTeachingData(selectedLocationIndex);
            SetYOutPosition((int)selectedLocationIndex, Teaching_Y_Out_Position, true);
        }

        [GenerateCommand]
        private void TeachingZUpPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateZUpPosition(selectedLocationIndex, Actual_Z_Position);
            UpdateLocationTeachingData(selectedLocationIndex);
            SetZUpPosition((int)selectedLocationIndex, Teaching_Z_Up_Position, true);
        }
        [GenerateCommand]
        private void TeachingZDownPositionSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateZDownPosition(selectedLocationIndex, Actual_Z_Position);
            UpdateLocationTeachingData(selectedLocationIndex);
            SetZDownPosition((int)selectedLocationIndex, Teaching_Z_Down_Position, true);
        }

        [GenerateCommand]
        private void TeachingTransferHandSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateTransferHand(selectedLocationIndex, Teaching_Transfer_Hand);
            UpdateLocationTeachingData(selectedLocationIndex);
            SetTransferHand((int)selectedLocationIndex, Teaching_Transfer_Hand, true);
        }

        [GenerateCommand]
        private void TeachingLocationTypeSetClick(RoutedEventArgs args)
        {
            LocationManager.Instance.UpdateLocationType(selectedLocationIndex, Teaching_Location_Type);
            UpdateLocationTeachingData(selectedLocationIndex);
            SetLocationType((int)selectedLocationIndex, Teaching_Location_Type, true);
        }

        [GenerateCommand]
        private void JogXAxisPlusFast(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogXAxisPlusSlow(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogXAxisMinusFast(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogXAxisMinusSlow(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, true);
        }

        [GenerateCommand]
        private void JogXAxisStop(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_Mode, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oXAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogYAxisPlusFast(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogYAxisPlusSlow(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogYAxisMinusFast(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogYAxisMinusSlow(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, true);
        }

        [GenerateCommand]
        private void JogYAxisStop(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_Mode, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oYAxis_nJog_BwSlow, false);
        }



        [GenerateCommand]
        private void JogZAxisPlusFast(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogZAxisPlusSlow(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogZAxisMinusFast(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void JogZAxisMinusSlow(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, true);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, true);
        }

        [GenerateCommand]
        private void JogZAxisStop(RoutedEventArgs args)
        {
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_Mode, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwFast, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_FwSlow, false);
            DataManager.Instance.SET_BOOL_DATA(IoNameHelper.oZAxis_nJog_BwSlow, false);
        }

        [GenerateCommand]
        private void ApplyButtonClick(RoutedEventArgs args)
        {
            List<LOCATION_INFO> locList = LocationManager.Instance.GetLocationList();

            foreach (LOCATION_INFO info in locList)
            {
                int id = Convert.ToInt32(info.LOCATION_ID);
                SetXPosition(id, info.X_POS);
                SetYInPosition(id, info.Y_IN_POS);
                SetYOutPosition(id, info.Y_OUT_POS);
                SetZUpPosition(id, info.Z_UP_POS);
                SetZDownPosition(id, info.Z_DOWN_POS);
                SetTransferHand(id, info.TRANSFER_HAND);
                SetLocationType(id, info.LOCATION_TYPE);
            }
        }

        private void SetXPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dXPos.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            } 
        }

        private void SetYInPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dYIn.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            }
        }

        private void SetYOutPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dYOut.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);
            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            }          
        }

        private void SetZUpPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dZUp.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            }
        }

        private void SetZDownPosition(int location_id, double position, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.dZDown.{0:000}", location_id);

            DataManager.Instance.SET_DOUBLE_DATA(ioName, position);
            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, position);
            }
        }

        private void SetTransferHand(int location_id, string leftRight, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.nHand.{0:000}", location_id);
            int nHand = 0;

            if (leftRight.StartsWith("L"))
            {
                nHand = 1;
            }
            else
            {
                nHand = 2;
            }

            DataManager.Instance.SET_INT_DATA(ioName, nHand);

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, nHand);
            }
            
        }

        private void SetLocationType(int location_id, string loc_type, bool io_defalut_set = false)
        {
            string ioName = string.Format("oLoc.nType.{0:000}", location_id);
            int nType = 0;

            if (loc_type.StartsWith("S"))
            {
                nType = 1;
            }
            else if (loc_type.StartsWith("P"))
            {
                nType = 2;
            }
            else if (loc_type.StartsWith("L"))
            {
                nType = 3;
            }
            else if (loc_type.StartsWith("B"))
            {
                nType = 4;
            }
            else
            {
                nType = 0;
            }

            DataManager.Instance.SET_INT_DATA(ioName, nType);       

            if (io_defalut_set)
            {
                DataManager.Instance.CHANGE_DEFAULT_DATA(ioName, nType);
            }
        }
    }
}
