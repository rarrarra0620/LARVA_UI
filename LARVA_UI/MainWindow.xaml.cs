using DevExpress.Xpf.Core;
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
using EPLE.IO;
using EPLE.App;
using LARVA.Scheduler;
using LARVA.Scheduler.Model;

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
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            EPLE.App.Engine.Instance.ConfigFilePath = @"./config/Server.Config.ini";
            EPLE.App.Engine.Instance.DbFilePath = @"./config/db_io.mdb";
            EPLE.App.Engine.Instance.Inialize();
            EPLE.App.Engine.Instance.Start();

            LARVA.Scheduler.JobManager.Instance.Initialize(@"./config/db_io.mdb");
            
            //LARVA.Scheduler.JobManager.Instance.CreateNewJob("TOBBAB_CHANGE", 10, "SEAN", "HOME");
        }

        /*
        private void navi_diagnostic_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new DiagnosticPage());
        }

        private void navi_main_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Views.MainView());
        }
        */

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}
