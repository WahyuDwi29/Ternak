#pragma checksum "..\..\..\..\View\BuyProductWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A211C9DE08836638F9C770D2AD16963FF690C8D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Final_Project_Pemrograman_Lanjut;
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


namespace Ternak_Admin.View {
    
    
    /// <summary>
    /// BuyProductWindow
    /// </summary>
    public partial class BuyProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\View\BuyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblProduct;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\View\BuyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgProduct;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\BuyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\BuyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNomor;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\BuyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbAlamat;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\BuyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbHarga;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\BuyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuy;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\View\BuyProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Ternak Admin;component/view/buyproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\BuyProductWindow.xaml"
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
            this.LblProduct = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ImgProduct = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.TbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbNomor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbAlamat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TbHarga = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnBuy = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\View\BuyProductWindow.xaml"
            this.btnBuy.Click += new System.Windows.RoutedEventHandler(this.BtnBuy_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btncancel = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\View\BuyProductWindow.xaml"
            this.btncancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

