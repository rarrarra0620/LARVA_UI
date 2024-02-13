using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LARVA_UI.UserControls
{
    /// <summary>
    /// PRO_Teaching.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PRO_Teaching : UserControl
    {
        public PRO_Teaching()
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