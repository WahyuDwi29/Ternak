﻿#pragma checksum "..\..\..\..\View\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CC465B561BACBC25B501E04871742B20C72B727C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
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
using Ternak_Admin;


namespace Ternak_Admin.View {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel HomePage;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel DataProduk;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel DataPembeli;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel CowPage;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel GoathPage;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel ChickenPage;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel Logout;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSearch;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgHistory;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblUser;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrmMain;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Ternak Admin;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HomePage = ((System.Windows.Controls.DockPanel)(target));
            
            #line 34 "..\..\..\..\View\MainWindow.xaml"
            this.HomePage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.HomePage_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataProduk = ((System.Windows.Controls.DockPanel)(target));
            
            #line 40 "..\..\..\..\View\MainWindow.xaml"
            this.DataProduk.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DataProduk_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataPembeli = ((System.Windows.Controls.DockPanel)(target));
            
            #line 46 "..\..\..\..\View\MainWindow.xaml"
            this.DataPembeli.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DataPembeli_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CowPage = ((System.Windows.Controls.DockPanel)(target));
            
            #line 52 "..\..\..\..\View\MainWindow.xaml"
            this.CowPage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CowPage_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GoathPage = ((System.Windows.Controls.DockPanel)(target));
            
            #line 58 "..\..\..\..\View\MainWindow.xaml"
            this.GoathPage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GoathPage_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ChickenPage = ((System.Windows.Controls.DockPanel)(target));
            
            #line 64 "..\..\..\..\View\MainWindow.xaml"
            this.ChickenPage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ChickenPage_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Logout = ((System.Windows.Controls.DockPanel)(target));
            
            #line 70 "..\..\..\..\View\MainWindow.xaml"
            this.Logout.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Logout_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\..\..\View\MainWindow.xaml"
            this.TbSearch.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TbSearch_OnGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ImgHistory = ((System.Windows.Controls.Image)(target));
            
            #line 96 "..\..\..\..\View\MainWindow.xaml"
            this.ImgHistory.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgHistory_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.LblUser = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.FrmMain = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

