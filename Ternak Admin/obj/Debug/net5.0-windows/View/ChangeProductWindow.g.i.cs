#pragma checksum "..\..\..\..\View\ChangeProductWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39FD244454C292DC51FFF1D73C313C0371E8ED70"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace Ternak_Admin.View {
    
    
    /// <summary>
    /// ChangeProductWindow
    /// </summary>
    public partial class ChangeProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\View\ChangeProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblProduct;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\ChangeProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNameCustomer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\ChangeProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNomor;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\ChangeProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbAlamat;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\ChangeProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNameProduct;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\ChangeProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbHarga;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\ChangeProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChange;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\View\ChangeProductWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Ternak Admin;V1.0.0.0;component/view/changeproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ChangeProductWindow.xaml"
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
            this.TbNameCustomer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TbNomor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbAlamat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbNameProduct = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TbHarga = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnChange = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\View\ChangeProductWindow.xaml"
            this.btnChange.Click += new System.Windows.RoutedEventHandler(this.BtnChange_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btncancel = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\View\ChangeProductWindow.xaml"
            this.btncancel.Click += new System.Windows.RoutedEventHandler(this.Btncancel_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

