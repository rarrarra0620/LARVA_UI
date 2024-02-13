using EPLE.App;
using EPLE.IO;
using DevExpress.Mvvm.CodeGenerators;
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
namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for ManualView.xaml
    /// </summary>
    public partial class ManualView : UserControl
    {
        private bool result;
        public ManualView()
        {
            InitializeComponent();
        }
        private void CylinderForward_Click(object sender, RoutedEventArgs e)
        {
            bool result = DataManager.Instance.SET_BOOL_DATA(IoNameHelper.iFlip_nImpCyl_L1_FwdBwd, true);
            // 실린더 전진 로직
        }

        private void CylinderBackward_Click(object sender, RoutedEventArgs e)
        {
            // 실린더 후진 로직
        }

        private void LedOn_Click(object sender, RoutedEventArgs e)
        {
            // LED On 로직
        }

        private void LedOff_Click(object sender, RoutedEventArgs e)
        {
            // LED Off 로직
        }

        private void FlipReverse_Click(object sender, RoutedEventArgs e)
        {
            // Flip 반전 로직
        }

        private void FlipNormal_Click(object sender, RoutedEventArgs e)
        {
            // Flip 정위치 로직
        }

        private void FlipConvShutter_Click(object sender, RoutedEventArgs e)
        {
            result = DataManager.Instance.SET_INT_DATA(IoNameHelper.iFlip_nOutShutter_UpDown, 1);
        }

        private void LoaderShutterOpen_Click(object sender, RoutedEventArgs e)
        {
            result = DataManager.Instance.SET_INT_DATA(IoNameHelper.iLoader_nShutter_UpDown, 1);
        }
    }
}
