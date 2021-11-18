﻿using ModernBoxes.MyEnum;
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
            //设置软件宽高数据初始化
            S_MainWindowHeight.Maximum = SystemParameters.WorkArea.Height;
            S_MainWindowHeight.Value = MainWindow.DoGetMainWindowHeight();

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
        /// 修改主界面的高
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void S_MainWindowHeight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MainWindow.DoSetMainWindowHeight(S_MainWindowHeight.Value);
        }

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
            autoOpenSoftware.SetAutoStart(true);
            ConfigHelper.setConfig("autoOpen", true);
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
            ConfigHelper.setConfig("autoOpen", false);
        }
    }
}