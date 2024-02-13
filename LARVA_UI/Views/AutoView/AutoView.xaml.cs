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
using DevExpress.Utils.Extensions;

namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for AutoView.xaml
    /// </summary>
    public partial class AutoView : UserControl
    {
        public AutoView()
        {
            InitializeComponent();
        }

        private void ZoneButton_Click(object sender, RoutedEventArgs e)
        {
            // 모든 버튼을 기본 색상으로 초기화
            btnZone_1.Background = Brushes.Transparent;
            btnZone_2.Background = Brushes.Transparent;
            btnZone_3.Background = Brushes.Transparent;
            btnZone_4.Background = Brushes.Transparent;
            btnZone_5.Background = Brushes.Transparent;
            btnZone_6.Background = Brushes.Transparent;
            btnZone_7.Background = Brushes.Transparent;
            btnZone_8.Background = Brushes.Transparent;

            // 클릭된 버튼의 색상을 변경
            if (sender is Button clickedButton)
            {
                clickedButton.Background = Brushes.SkyBlue;
            }


            // ViewModel의 인스턴스를 얻음
            if (this.DataContext is AutoViewModel viewModel)
            {
                // 선택된 박스들 초기화
                viewModel.ClearSelectedBoxes();

                // ToggleButton의 IsChecked 속성 강제로 false로 설정
                foreach (var control in BoxGroup_1.Children)
                {
                    if (control is ToggleButton toggleButton)
                    {
                        toggleButton.IsChecked = false;
                    }
                }
                foreach (var control in BoxGroup_2.Children)
                {
                    if (control is ToggleButton toggleButton)
                    {
                        toggleButton.IsChecked = false;
                    }
                }
                foreach (var control in BoxGroup_3.Children)
                {
                    if (control is ToggleButton toggleButton)
                    {
                        toggleButton.IsChecked = false;
                    }
                }

            }
        }

        private void BoxLevelButton_Click(object sender, RoutedEventArgs e)
        {
            // ViewModel의 인스턴스를 얻음
            if (this.DataContext is AutoViewModel viewModel)
            {
                var popup = new BoxLevelWindow();
                if (popup.ShowDialog() == true)
                {
                    string selectedStage = popup.SelectedStage; // 사용자가 선택한 박스 레벨

                    foreach (var control in BoxGroup_1.Children)
                    {
                        if (control is ToggleButton toggleButton && toggleButton.IsChecked == true)
                        {
                            viewModel.SetBoxLevel(toggleButton.Content.ToString(), selectedStage);

                            // Content에서 현재 박스 레벨을 찾아서 새로운 레벨로 교체
                            string currentContent = toggleButton.Content.ToString();
                            string newContent = ReplaceBoxStage(currentContent, selectedStage);
                            toggleButton.Content = newContent;
                        }
                    }
                    foreach (var control in BoxGroup_2.Children)
                    {
                        if (control is ToggleButton toggleButton && toggleButton.IsChecked == true)
                        {
                            viewModel.SetBoxLevel(toggleButton.Content.ToString(), selectedStage);

                            // Content에서 현재 박스 레벨을 찾아서 새로운 레벨로 교체
                            string currentContent = toggleButton.Content.ToString();
                            string newContent = ReplaceBoxStage(currentContent, selectedStage);
                            toggleButton.Content = newContent;
                        }
                    }
                    foreach (var control in BoxGroup_3.Children)
                    {
                        if (control is ToggleButton toggleButton && toggleButton.IsChecked == true)
                        {
                            viewModel.SetBoxLevel(toggleButton.Content.ToString(), selectedStage);

                            // Content에서 현재 박스 레벨을 찾아서 새로운 레벨로 교체
                            string currentContent = toggleButton.Content.ToString();
                            string newContent = ReplaceBoxStage(currentContent, selectedStage);
                            toggleButton.Content = newContent;
                        }
                    }
                }
            }
        }

        private string ReplaceBoxStage(string currentContent, string newStage)
        {
            // 현재 Content에서 마지막 줄(현재 박스 레벨)을 찾아서 새로운 레벨로 교체
            var lines = currentContent.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length > 1)
            {
                lines[lines.Length - 1] = newStage; // 마지막 줄을 새로운 레벨로 교체
                return string.Join("\n", lines);
            }
            else
            {
                return currentContent + newStage;
            }
        }
    }
}
