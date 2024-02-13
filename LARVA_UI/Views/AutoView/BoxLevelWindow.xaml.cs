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
using System.Windows.Shapes;


namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for BoxLevelWindow.xaml
    /// </summary>
    public partial class BoxLevelWindow : ThemedWindow
    {

        public string SelectedStage { get; private set; }
        public int selfLevel = 0;
        private Button lastSelectedButton = null;

        public Dictionary<string, int> stageLevels = new Dictionary<string, int>
    {
        { "성충", 1 },
        { "알", 2 },
        { "1~2령", 3 },
        { "3령", 4 },
        { "3령금식", 5 },
        { "3령출하", 6 },
        { "코쿤", 7 }
    };

        public BoxLevelWindow()
        {
            InitializeComponent();
            buttonList.ItemsSource = stageLevels.Keys;
        }
        private void StageButton_Click(object sender, RoutedEventArgs e)
        {

            // 이전에 선택된 버튼의 색상을 초기화합니다.
            if (lastSelectedButton != null)
            {
                lastSelectedButton.Background = Brushes.Transparent; // 기본 배경색으로 변경
            }

            Button clickedButton = (Button)sender;
            clickedButton.Background = Brushes.SkyBlue;
            lastSelectedButton = clickedButton;
            SelectedStage = clickedButton.Content.ToString();

            if (stageLevels.TryGetValue(SelectedStage, out int level))
            {
                selfLevel = level;
            }
            else
            {
                selfLevel = 0;
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedStage != null)
            {

                this.DialogResult = true;
            }
        }
    }
}
