using DevExpress.Data.Browsing;
using DevExpress.Mvvm;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using static DevExpress.XtraEditors.Filtering.DataItemsExtension;



namespace LARVA_UI.UserControls
{
    /// <summary>
    /// Interaction logic for Y_AxisSetting.xaml
    /// </summary>
    public partial class Y_AxisSetting : UserControl
    {
        public ObservableCollection<GridDataItem> DataItems { get; private set; }

        public Y_AxisSetting()
        {
            InitializeComponent();
        }

        private void JogNegative_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JogPositive_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JogSpeedLow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JogSpeedMid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JogSpeedHigh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReadData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SimpleButton_Click(object sender, RoutedEventArgs e)
        {

        }


        public class GridDataItem
        {
            public int Number { get; set; }
            public double TargetPosition { get; set; }
            public double TargetSpeed { get; set; }
            public string Description { get; set; }
        }

        public void AddDataItem(int number, double targetposition, double targetSpeed, string description)
        {
            DataItems.Add(new GridDataItem
            {
                Number = number,
                TargetPosition = targetposition,
                TargetSpeed = targetSpeed,
                Description = description
            });
            OnPropertyChanged("DataItems");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void InitializeData()
        {
            DataItems = new ObservableCollection<GridDataItem>();
            AddDataItem(1, 100.00, 10.00, "박스공급");
            //AddDataItem(2, 100.00, 10.00, "박스세척");
        }




        //public Y_AxisSetting()
        //{
        //    DataItems = new ObservableCollection<GridDataItem>();
        //    AddDataItem(1, 100.00, 10, "박스공급");
        //    AddDataItem(2, 100.00, 10, "박스세척");
        //}


    }
    //public partial class Y_AxisSetting : UserControl
    //{
    //    public Y_AxisSetting()
    //    {
    //        InitializeComponent();
    //        ViewModels viewModel = new ViewModels();
    //        DataContext = viewModel;
    //    }

    //}

}


//public event EventHandler JognegetiveClicked;
//public event EventHandler JogPositiveClicked;
//public event EventHandler JogSpeedLowClicked;
//public event EventHandler JogSpeedMidClicked;
//public event EventHandler JogSpeedHighClicked;
//public event EventHandler ReadDataClicked;
//public event EventHandler SaveDataClicked;


//private void JogNegative_Click(object sender, RoutedEventArgs e)
//{
//    JognegetiveClicked?.Invoke(sender, e);
//}

//private void JogPositive_Click(object sender, RoutedEventArgs e)
//{
//    JogPositiveClicked?.Invoke(sender, e);
//}

//private void JogSpeedLow_Click(object sender, RoutedEventArgs e)
//{
//    JogSpeedLowClicked?.Invoke(sender, e);
//}

//private void JogSpeedMid_Click(object sender, RoutedEventArgs e)
//{
//    JogSpeedMidClicked?.Invoke(sender, e);
//}

//private void JogSpeedHigh_Click(object sender, RoutedEventArgs e)
//{
//    JogSpeedHighClicked?.Invoke(sender, e);
//}

//private void ReadData_Click(object sender, RoutedEventArgs e)
//{
//    ReadDataClicked?.Invoke(sender, e);
//}

//private void SaveData_Click(object sender, RoutedEventArgs e)
//{
//    SaveDataClicked?.Invoke(sender, e);
//}
