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
using EPLE.App;
using EPLE.IO;

namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for IoMonitoringView.xaml
    /// </summary>
    public partial class IoMonitoringView : UserControl
    {
        public IoMonitoringView()
        {
            InitializeComponent();
            
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            
  
        }


        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            bool result = false;

            TEST.Dispatcher.BeginInvoke(new Action(() =>
            {

                TEST.Text = DataManager.Instance.GET_DOUBLE_DATA(IoNameHelper.iHvac_fCurrent_Temp, out result).ToString();
            }));

        }
    }
}
