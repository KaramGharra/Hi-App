﻿#pragma checksum "..\..\VideoW.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BBB35C8621B50A8AFEDD7C03A5B293EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HiWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace HiWPF {
    
    
    /// <summary>
    /// VideoW
    /// </summary>
    public partial class VideoW : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\VideoW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangle1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\VideoW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Integration.WindowsFormsHost wfServer;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\VideoW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Integration.WindowsFormsHost wfClient;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\VideoW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIP;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\VideoW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCall;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\VideoW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDevices;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\VideoW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
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
            System.Uri resourceLocater = new System.Uri("/HiWPF;component/videow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VideoW.xaml"
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
            
            #line 8 "..\..\VideoW.xaml"
            ((HiWPF.VideoW)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\VideoW.xaml"
            ((HiWPF.VideoW)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rectangle1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.wfServer = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 4:
            this.wfClient = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 5:
            this.txtIP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnCall = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\VideoW.xaml"
            this.btnCall.Click += new System.Windows.RoutedEventHandler(this.btnCall_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbDevices = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\VideoW.xaml"
            this.cbDevices.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbDevices_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

