// Updated by XamlIntelliSenseFileGenerator 28.6.2022. 11:10:12
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "626DC14DA3E8C1DA25A024C64FC66B0128A987D9311E38903E85C3F94B0496D5"
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
using WPF_Projekt;


namespace WPF_Projekt
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbMale;

#line default
#line hidden


#line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFemale;

#line default
#line hidden


#line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbOnline;

#line default
#line hidden


#line 93 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbOffline;

#line default
#line hidden


#line 111 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTeams;

#line default
#line hidden


#line 136 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbSmall;

#line default
#line hidden


#line 151 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbMedium;

#line default
#line hidden


#line 166 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbLarge;

#line default
#line hidden


#line 181 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFullscreen;

#line default
#line hidden


#line 189 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbCheckedScreenSizeMessage;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF Projekt;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 8 "..\..\MainWindow.xaml"
                    ((WPF_Projekt.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MainWindow_Loaded);

#line default
#line hidden

#line 9 "..\..\MainWindow.xaml"
                    ((WPF_Projekt.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);

#line default
#line hidden
                    return;
                case 2:
                    this.rbMale = ((System.Windows.Controls.RadioButton)(target));

#line 48 "..\..\MainWindow.xaml"
                    this.rbMale.Checked += new System.Windows.RoutedEventHandler(this.rbMale_Checked);

#line default
#line hidden
                    return;
                case 3:
                    this.rbFemale = ((System.Windows.Controls.RadioButton)(target));

#line 61 "..\..\MainWindow.xaml"
                    this.rbFemale.Checked += new System.Windows.RoutedEventHandler(this.rbFemale_Checked);

#line default
#line hidden
                    return;
                case 4:
                    this.rbOnline = ((System.Windows.Controls.RadioButton)(target));

#line 78 "..\..\MainWindow.xaml"
                    this.rbOnline.Checked += new System.Windows.RoutedEventHandler(this.rbOnline_Checked);

#line default
#line hidden
                    return;
                case 5:
                    this.rbOffline = ((System.Windows.Controls.RadioButton)(target));

#line 94 "..\..\MainWindow.xaml"
                    this.rbOffline.Checked += new System.Windows.RoutedEventHandler(this.rbOffline_Checked);

#line default
#line hidden
                    return;
                case 6:
                    this.cbTeams = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 7:
                    this.rbSmall = ((System.Windows.Controls.RadioButton)(target));

#line 137 "..\..\MainWindow.xaml"
                    this.rbSmall.Checked += new System.Windows.RoutedEventHandler(this.rbScreenSize_Checked);

#line default
#line hidden
                    return;
                case 8:
                    this.rbMedium = ((System.Windows.Controls.RadioButton)(target));

#line 152 "..\..\MainWindow.xaml"
                    this.rbMedium.Checked += new System.Windows.RoutedEventHandler(this.rbScreenSize_Checked);

#line default
#line hidden
                    return;
                case 9:
                    this.rbLarge = ((System.Windows.Controls.RadioButton)(target));

#line 167 "..\..\MainWindow.xaml"
                    this.rbLarge.Checked += new System.Windows.RoutedEventHandler(this.rbScreenSize_Checked);

#line default
#line hidden
                    return;
                case 10:
                    this.rbFullscreen = ((System.Windows.Controls.RadioButton)(target));

#line 182 "..\..\MainWindow.xaml"
                    this.rbFullscreen.Checked += new System.Windows.RoutedEventHandler(this.rbScreenSize_Checked);

#line default
#line hidden
                    return;
                case 11:
                    this.lbCheckedScreenSizeMessage = ((System.Windows.Controls.Label)(target));
                    return;
                case 12:

#line 199 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowPlayers_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btnCro;
        internal System.Windows.Controls.Button btnEng;
    }
}

