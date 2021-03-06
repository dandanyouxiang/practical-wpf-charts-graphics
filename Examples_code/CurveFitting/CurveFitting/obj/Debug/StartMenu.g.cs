﻿#pragma checksum "..\..\StartMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EA84C574EF437889A1E5CE4A53864FEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
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


namespace CurveFitting {
    
    
    /// <summary>
    /// StartMenu
    /// </summary>
    public partial class StartMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\StartMenu.xaml"
        internal System.Windows.Controls.Button Straightline;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\StartMenu.xaml"
        internal System.Windows.Controls.Button Linear;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\StartMenu.xaml"
        internal System.Windows.Controls.Button Polynomial;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\StartMenu.xaml"
        internal System.Windows.Controls.Button weighted;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\StartMenu.xaml"
        internal System.Windows.Controls.Button Close;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CurveFitting;component/startmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StartMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Straightline = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\StartMenu.xaml"
            this.Straightline.Click += new System.Windows.RoutedEventHandler(this.Straightline_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Linear = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\StartMenu.xaml"
            this.Linear.Click += new System.Windows.RoutedEventHandler(this.Linear_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Polynomial = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\StartMenu.xaml"
            this.Polynomial.Click += new System.Windows.RoutedEventHandler(this.Polynomial_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.weighted = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\StartMenu.xaml"
            this.weighted.Click += new System.Windows.RoutedEventHandler(this.Weighted_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Close = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\StartMenu.xaml"
            this.Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
