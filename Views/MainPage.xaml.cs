// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Documents;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TextBlockInlinesWinUI3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // コードビハインドでInlines追加
            InitMyTextBlock();
        }

        private void InitMyTextBlock()
        {
            myTextBlock.Inlines.Clear();
            var default1 = new Run() { Text = "デフォルトのサイズ2" };
            var default2 = new Run() { Text = "デフォルトのサイズ2" };
            var large = new Run() { Text = "大きいサイズ", FontSize = 40 };
            var bold = new Run() { Text = "太字", FontWeight = FontWeights.Bold };
            var small = new Run() { Text = "小さいサイズ", FontSize = 10 };
            myTextBlock.Inlines.Add(default1);
            myTextBlock.Inlines.Add(default2);
            myTextBlock.Inlines.Add(large);
            myTextBlock.Inlines.Add(bold);
            myTextBlock.Inlines.Add(small);
        }
    }
}
