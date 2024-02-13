using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
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
using System.Xml.Linq;
using DevExpress.Xpf.Core;
using EPLE.App;
using EPLE.IO;
using LARVA_UI.UserControls;

namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for DigitalIoPage.xaml
    /// </summary>
    public partial class DiagnosticPage : UserControl
    {
        private ObservableCollection<DigitalIndicator> DigitalInputs = new ObservableCollection<DigitalIndicator>();
        private ObservableCollection<DigitalIndicator> DigitalOutputs = new ObservableCollection<DigitalIndicator>();
        private System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        public DiagnosticPage()
        {
            InitializeComponent();

        }

        #region Page Init and End
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<Data> ioList = new List<Data>(DataManager.Instance.GET_DATA_BY_MODULE("PIO"));

            foreach (Data data in ioList)
            {
                if (data.Direction == eDirection.IN)
                {
                    DigitalIndicator LED = new DigitalIndicator();
                    LED.IoName = data.Name;
                    LED.Caption = data.Name;
                    //LED.DigitalIndicatorClicked += DigitalIndicator_Clicked;
                    DigitalInputs.Add(LED);
                }
                else if (data.Direction == eDirection.OUT)
                {
                    DigitalIndicator LED = new DigitalIndicator();
                    LED.IoName = data.Name;
                    LED.Caption = data.Name;
                    LED.DigitalIndicatorClicked += DigitalOutput_Clicked;
                    DigitalOutputs.Add(LED);
                }
            }

            if (DigitalInputs.Count >= 90)
            {
                for (int i = 0; i < 90; i++)
                {
                    DiContent1.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = 0; i < DigitalInputs.Count; i++)
                {
                    DiContent1.Children.Add(DigitalInputs[i]);
                }
            }


            if (DigitalInputs.Count >= 180)
            {
                for (int i = 90; i < 180; i++)
                {
                    DiContent2.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = 90; i < DigitalInputs.Count; i++)
                {
                    DiContent2.Children.Add(DigitalInputs[i]);
                }
            }


            if (DigitalInputs.Count >= 270)
            {
                for (int i = 180; i < 270; i++)
                {
                    DiContent3.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = 180; i < DigitalInputs.Count; i++)
                {
                    DiContent3.Children.Add(DigitalInputs[i]);
                }
            }

            if (DigitalInputs.Count >= 360)
            {
                for (int i = 270; i < 360; i++)
                {
                    DiContent4.Children.Add(DigitalInputs[i]);
                }
            }
            else
            {
                for (int i = 270; i < DigitalInputs.Count; i++)
                {
                    DiContent4.Children.Add(DigitalInputs[i]);
                }
            }


            if (DigitalOutputs.Count >= 90)
            {
                for (int i = 0; i < 90; i++)
                {
                    DoContent1.Children.Add(DigitalOutputs[i]);
                }
            }
            else
            {
                for (int i = 0; i < DigitalOutputs.Count; i++)
                {
                    DoContent1.Children.Add(DigitalOutputs[i]);
                }
            }

            

            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
        #endregion

        #region Timer poll

        #endregion

        private void DigitalOutput_Clicked(object sender, DigitalIndicator.DigitalIndicationEventArgs e)
        {
            DigitalIndicator digitalOutput = (DigitalIndicator)sender;

            int value = digitalOutput.State > 0 ? 0 : 1; // value change as true or false

            DataManager.Instance.SET_INT_DATA(digitalOutput.IoName, value);
        }

        public void MainContent_SelectionChanged(object sender, DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs e)
        {

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < DigitalOutputs.Count; i++)
            {
                DigitalOutputs[i].State = (short)DataManager.Instance.GET_INT_DATA(DigitalOutputs[i].IoName, out bool result);
            }
            for (int i = 0; i < DigitalInputs.Count; i++)
            {
                DigitalInputs[i].State = (short)DataManager.Instance.GET_INT_DATA(DigitalInputs[i].IoName, out bool result);
            }
            //for (int i = 0; i < DigitalOutputs.Count; i++)
            //{
            //    DigitalOutputs[i].State = (short)DataManager.Instance.GET_INT_DATA(DigitalOutputs[i].IoName, out bool result);
            //}
        }
    }
}
