﻿#pragma checksum "..\..\AddEvent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99AC0A87AE5589C1709591CB7AEFD5FE7ADB67AAB9F25317559C6C97D0F86C87"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using _3_1;


namespace _3_1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgevent12;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numb_eventtx;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox date_eventtx;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox locationntx;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name_eventtx;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox street_eventtx;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox house_eventtx;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox delete_eventtx;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/3_1;component/addevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEvent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\AddEvent.xaml"
            ((_3_1.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_loaded_dg);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgevent12 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.numb_eventtx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.date_eventtx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.locationntx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.name_eventtx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.street_eventtx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.house_eventtx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.delete_eventtx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 31 "..\..\AddEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Insert_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 32 "..\..\AddEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 33 "..\..\AddEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
