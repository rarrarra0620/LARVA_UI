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
using DevExpress.Xpf.Grid;

namespace LARVA_UI.UserControls
{
    public partial class X_AxisSetting : UserControl

    {
        public X_AxisSetting()
        {
            InitializeComponent();
        }

        public event EventHandler JognegetiveClicked;
        public event EventHandler JogPositiveClicked;
        public event EventHandler JogSpeedLowClicked;
        public event EventHandler JogSpeedMidClicked;
        public event EventHandler JogSpeedHighClicked;
        public event EventHandler ReadDataClicked;
        public event EventHandler SaveDataClicked;


        private void JogNegative_Click(object sender, RoutedEventArgs e)
        {
            JognegetiveClicked?.Invoke(sender, e);
        }

        private void JogPositive_Click(object sender, RoutedEventArgs e)
        {
            JogPositiveClicked?.Invoke(sender, e);
        }

        private void JogSpeedLow_Click(object sender, RoutedEventArgs e)
        {
            JogSpeedLowClicked?.Invoke(sender, e);
        }

        private void JogSpeedMid_Click(object sender, RoutedEventArgs e)
        {
            JogSpeedMidClicked?.Invoke(sender, e);
        }

        private void JogSpeedHigh_Click(object sender, RoutedEventArgs e)
        {
            JogSpeedHighClicked?.Invoke(sender, e);
        }

        private void ReadData_Click(object sender, RoutedEventArgs e)
        {
            ReadDataClicked?.Invoke(sender, e);
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {
            SaveDataClicked?.Invoke(sender, e);
        }
    }
    
}




//    /// <summary>
//    /// Interaction logic for X_AxisSetting.xaml
//    /// </summary>
//    public partial class X_AxisSetting : UserControl
//    {

//        public ObservableCollection<GridDataItem> Table { get; set; }


//        public X_AxisSetting()
//        {
//            InitializeComponent();
//            Table = new ObservableCollection<GridDataItem>();
//            InitializeData();
//            DataContext = this;
//        }

//        private void InitializeData()
//        {
//            Table.Add(new GridDataItem { Number = 1, TargetPosition = 100, TargetSpeed = 10, Description = "박스공급" });
//            Table.Add(new GridDataItem { Number = 2, TargetPosition = 200, TargetSpeed = 20, Description = "세척" });
//        }

//    }

//    public class GridDataItem
//    {
//        public int Number { get; set; }
//        public int TargetPosition { get; set; }
//        public int TargetSpeed { get; set; }
//        public string Description { get; set; }
//    }
//}
