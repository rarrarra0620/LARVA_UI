using DevExpress.Xpf.Core;
using LARVA_UI.TwinCATConnector;
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

namespace LARVA_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Config.SetupManager.Load_DiagConfig();

            switch (TwincatConnector.tcConnect())
            {
                case tcFunctionResult.TC_SUCCESS:
                    if (TwincatConnector.tcCreateHandle() == tcFunctionResult.TC_SUCCESS)
                    {
                    }
                    else
                    {
                    }
                    break;
                case tcFunctionResult.TC_FAIL_TO_LOAD_PLC_CONFIG:
                    break;
                case tcFunctionResult.TC_FAIL_TO_CONNECT_DEVICE:
                    break;
            }

        }

        private void navi_diagnostic_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new DiagnosticPage());
        }

        private void navi_main_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Views.MainView());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TwincatConnector.tcDispose();
        }
    }
}
