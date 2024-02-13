using LARVA_UI.ViewModels;
using LARVA_UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;

namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for AlarmView.xaml
    /// </summary>
    public partial class AlarmView : UserControl
    {
        public AlarmView()
        {
            InitializeComponent();
        }

        private void AlarmContent_SelectionChanged(object sender, DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs e)
        {

        }
    }
}
