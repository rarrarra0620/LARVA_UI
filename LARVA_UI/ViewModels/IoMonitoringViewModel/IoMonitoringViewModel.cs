using System.Collections.ObjectModel;
using DevExpress.Mvvm.CodeGenerators;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class IoMonitoringViewModel
    {
        public class TabDataItem
        {
            public string PageText { get; set; }
            public string HeaderText { get; set; }
        }

        private ObservableCollection<TabDataItem> tabDataItems;

        public IoMonitoringViewModel()
        {
            tabDataItems = new ObservableCollection<TabDataItem>();
        }

        public ObservableCollection<TabDataItem> TabDataItems { 
            get { return tabDataItems; } 
        }
    }
}
