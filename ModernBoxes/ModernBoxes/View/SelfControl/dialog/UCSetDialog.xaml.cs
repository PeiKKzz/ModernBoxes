using GalaSoft.MvvmLight.Messaging;
using ModernBoxes.MyEnum;
using ModernBoxes.Tool;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ModernBoxes.View.SelfControl.dialog
{
    /// <summary>
    /// UCSetDialog.xaml 的交互逻辑
    /// </summary>
    public partial class UCSetDialog : UserControl
    {
        public UCSetDialog()
        {
            InitializeComponent();
            init();
            Messenger.Default.Register<Boolean>(this, "IsSaveConfigData", SaveConfigData);
            
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="obj"></param>
        private void SaveConfigData(bool obj)
        {
            //保存组件宽度的数据
            ConfigHelper.setConfig("ComponentWidth", S_CompontentWidth.Value);
        }

        /// <summary>
        /// 设置界面初始化
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void init()
        {
            //初始化组件应用的方向/
            CommentLayout layoutOration = (CommentLayout)Enum.Parse(typeof(CommentLayout), ConfigHelper.getConfig("compontentLayout"));
            RB_ShowLeft.IsChecked = layoutOration == CommentLayout.left ? true : false;
            RB_ShowRight.IsChecked = layoutOration == CommentLayout.right ? true : false;
           
            S_CompontentWidth.Maximum = 420;
            S_CompontentWidth.Value = MainWindow.DoGetCompontentWidth();

            String autoOpen = ConfigHelper.getConfig("autoOpen");
            if (autoOpen != null&&autoOpen!=String.Empty)
            {
                if (Boolean.Parse(autoOpen))
                {
                    RB_AutoOpen.IsChecked = true;
                }
                else
                {
                    RB_NotAutoOpen.IsChecked = true;
                }
            }

            Theme theme = (Theme)Enum.Parse(typeof(Theme), ConfigHelper.getConfig("theme"));
            if (theme == Theme.light)
            {
                RB_light.IsChecked = true;
                RB_Dark.IsChecked = false;
            }
            else
            {
                RB_Dark.IsChecked = true;
                RB_light.IsChecked = false;
            }

            RB_HoverOpen.IsChecked = Boolean.Parse(ConfigHelper.getConfig("IsHover"));
        }

        /// <summary>
        /// 切换为光明系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RB_light_Click(object sender, RoutedEventArgs e)
        {
            ChangeTheme.SetTheme(Theme.light);
        }

        /// <summary>
        /// 切换为黑暗系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RB_Dark_Click(object sender, RoutedEventArgs e)
        {
            ChangeTheme.SetTheme(Theme.dark);   
        }

        

        /// <summary>
        /// 组件应用布局
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void layoutinleft_Click(object sender, RoutedEventArgs e)
        {
            ConfigHelper.setConfig("compontentLayout", CommentLayout.left);
            //设置完成之后关闭界面中的组件页面
            MainWindow.DoCloseCompontentLayout();
        }

        private void layoutinright_Click(object sender, RoutedEventArgs e)
        {
            ConfigHelper.setConfig("compontentLayout", CommentLayout.right);
            MainWindow.DoCloseCompontentLayout();
        }

        
        /// <summary>
        /// 设置组件宽度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void S_CompontentWidth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MainWindow.DoSetCompontentWidth(S_CompontentWidth.Value);
        }

        /// <summary>
        /// 启用自启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            AutoOpenSoftware autoOpenSoftware = new AutoOpenSoftware();
            ConfigHelper.setConfig("autoOpen", true);
            autoOpenSoftware.SetAutoStart(true);
        }

        /// <summary>
        /// 停用自启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            AutoOpenSoftware autoOpenSoftware = new AutoOpenSoftware();
            autoOpenSoftware.SetAutoStart(false);
            //autoOpenSoftware.setOpen(false);
            ConfigHelper.setConfig("autoOpen", false);
        }

        private void RB_HoverOpen_Click(object sender, RoutedEventArgs e)
        {
            ConfigHelper.setConfig("IsHover", RB_HoverOpen.IsChecked);
        }

        private void RB_HoverClose_Click(object sender, RoutedEventArgs e)
        {
            ConfigHelper.setConfig("IsHover", RB_HoverOpen.IsChecked);
        }
    }
}