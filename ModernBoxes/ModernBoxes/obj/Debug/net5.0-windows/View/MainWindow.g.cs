﻿#pragma checksum "..\..\..\..\View\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "249B0D3CCD4D08AFD3D8951680665A2745CFA112"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ModernBoxes {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ModernBoxes.MainWindow window;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.Card MiddleWindow;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Toggle;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem topItem;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem BottomItem;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btn_fixed;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btn_close;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl items;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfigMenu;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TransitioningContentControl compontentLayoutLeft;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl LeftContent;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TransitioningContentControl compontentLayoutRight;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl RightContent;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NotifyIcon NotifyIconContextContent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ModernBoxes;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.window = ((ModernBoxes.MainWindow)(target));
            return;
            case 2:
            this.MiddleWindow = ((HandyControl.Controls.Card)(target));
            return;
            case 3:
            this.Toggle = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 4:
            this.topItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 63 "..\..\..\..\View\MainWindow.xaml"
            this.topItem.Click += new System.Windows.RoutedEventHandler(this.topItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BottomItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 69 "..\..\..\..\View\MainWindow.xaml"
            this.BottomItem.Click += new System.Windows.RoutedEventHandler(this.BottomItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_fixed = ((System.Windows.Controls.MenuItem)(target));
            
            #line 76 "..\..\..\..\View\MainWindow.xaml"
            this.btn_fixed.Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_To_Fixed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_close = ((System.Windows.Controls.MenuItem)(target));
            
            #line 81 "..\..\..\..\View\MainWindow.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_To_CloseWindow);
            
            #line default
            #line hidden
            return;
            case 8:
            this.items = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 11:
            this.btnConfigMenu = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.compontentLayoutLeft = ((HandyControl.Controls.TransitioningContentControl)(target));
            return;
            case 13:
            this.LeftContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 14:
            this.compontentLayoutRight = ((HandyControl.Controls.TransitioningContentControl)(target));
            return;
            case 15:
            this.RightContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 16:
            this.NotifyIconContextContent = ((HandyControl.Controls.NotifyIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 115 "..\..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCardApp_Click);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 120 "..\..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDeleteMenuItem_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

