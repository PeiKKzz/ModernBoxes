using ModernBoxes.ViewModel;
using System;
using System.Windows.Controls;

namespace ModernBoxes.View.SelfControl
{
    /// <summary>
    /// UcCompotent.xaml 的交互逻辑
    /// </summary>
    public partial class UcCompotent : UserControl
    {
        public UcCompotent()
        {
            InitializeComponent();
            this.DataContext = new UcCompontentViewModel();
        }

        private void UserControl_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            Console.WriteLine(ScrollViewer.VerticalOffset + "  " + e.Delta);
            ScrollViewer.ScrollToVerticalOffsetWithAnimation(ScrollViewer.VerticalOffset - e.Delta);
        }
    }
}