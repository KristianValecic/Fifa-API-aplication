﻿#pragma checksum "..\..\..\Windows\ChosenPlayerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06547BD5D831A8D7B70845297E3E15323E32FA18C8E79368539D854BD77B7023"
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
using WPF_Projekt.Windows;


namespace WPF_Projekt.Windows {
    
    
    /// <summary>
    /// ChosenPlayerWindow
    /// </summary>
    public partial class ChosenPlayerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\Windows\ChosenPlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlrName;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\ChosenPlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlrNumber;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\ChosenPlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgPlr;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Windows\ChosenPlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlrGoalCount;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Windows\ChosenPlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlryellowCardCount;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Windows\ChosenPlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlrPosition;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Windows\ChosenPlayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlrIsCaptain;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF Projekt;component/windows/chosenplayerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ChosenPlayerWindow.xaml"
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
            
            #line 8 "..\..\..\Windows\ChosenPlayerWindow.xaml"
            ((WPF_Projekt.Windows.ChosenPlayerWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblPlrName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblPlrNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.imgPlr = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.lblPlrGoalCount = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblPlryellowCardCount = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblPlrPosition = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblPlrIsCaptain = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
