using DevExpress.Mvvm.CodeGenerators;
using System.Windows.Controls;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class MainViewModel
    {
        [GenerateProperty]
        string _Status;
        [GenerateProperty]
        string _UserName;

        [GenerateCommand]
        void Login() => Status = "User: " + UserName;
        bool CanLogin() => !string.IsNullOrEmpty(UserName);

        public void MainContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
