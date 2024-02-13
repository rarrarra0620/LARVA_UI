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
using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Mvvm;
using DevExpress.Xpf.Core;

namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();

        }

        private void TextEditSetVelocity_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ucAxisX_ServoEnableClicked(object sender, EventArgs e)
        {
            //ucAxisX.ServoState = "1";
        }
    }
}
