// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Text;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Documents;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TextBlockInlinesWinUI3
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var mainWindowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = AppWindow.GetFromWindowId(mainWindowId);

            // ウィンドウサイズを指定する
            appWindow.Resize(new(600, 300));

            // ウィンドウサイズを変更不能にする
            var presenter = appWindow.Presenter as OverlappedPresenter;
            presenter.IsResizable = false;

            // コードビハインドでInlines追加
            InitMyTextBlock();
        }

        private void InitMyTextBlock()
        {
            myTexxtBlock.Inlines.Clear();
            var default1 = new Run() { Text = "デフォルトのサイズ2" };
            var default2 = new Run() { Text = "デフォルトのサイズ2" };
            var large = new Run() { Text = "大きいサイズ", FontSize = 40 };
            var bold = new Run() { Text = "太字", FontWeight = FontWeights.Bold };
            var small = new Run() { Text = "小さいサイズ", FontSize = 10 };
            myTexxtBlock.Inlines.Add(default1);
            myTexxtBlock.Inlines.Add(default2);
            myTexxtBlock.Inlines.Add(large);
            myTexxtBlock.Inlines.Add(bold);
            myTexxtBlock.Inlines.Add(small);
        }
    }
}
