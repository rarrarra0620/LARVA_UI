using LARVA_UI.ViewModels.SettingViewModel;
using System;
using System.Collections.Generic;
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

namespace LARVA_UI.UserControls
{
    /// <summary>
    /// Interaction logic for Z_AxisSetting.xaml
    /// </summary>
    public partial class Z_AxisSetting : UserControl
    {
        public Z_AxisSetting()
        {
            InitializeComponent();
            ViewModel v = new ViewModel();
            this.DataContext = v;
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
    }
}
