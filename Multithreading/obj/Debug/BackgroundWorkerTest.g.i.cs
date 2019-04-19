﻿#pragma checksum "..\..\BackgroundWorkerTest.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "04A53DCADB46F37A6ED41BC21F870FF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
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


namespace Multithreading {
    
    
    /// <summary>
    /// BackgroundWorkerTest
    /// </summary>
    public partial class BackgroundWorkerTest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\BackgroundWorkerTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFrom;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\BackgroundWorkerTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\BackgroundWorkerTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdFind;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\BackgroundWorkerTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdCancel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\BackgroundWorkerTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstPrimes;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\BackgroundWorkerTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
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
            System.Uri resourceLocater = new System.Uri("/Multithreading;component/backgroundworkertest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BackgroundWorkerTest.xaml"
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
            
            #line 10 "..\..\BackgroundWorkerTest.xaml"
            ((System.ComponentModel.BackgroundWorker)(target)).DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            
            #line default
            #line hidden
            
            #line 10 "..\..\BackgroundWorkerTest.xaml"
            ((System.ComponentModel.BackgroundWorker)(target)).ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\BackgroundWorkerTest.xaml"
            ((System.ComponentModel.BackgroundWorker)(target)).RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFrom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtTo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cmdFind = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\BackgroundWorkerTest.xaml"
            this.cmdFind.Click += new System.Windows.RoutedEventHandler(this.cmdFind_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmdCancel = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\BackgroundWorkerTest.xaml"
            this.cmdCancel.Click += new System.Windows.RoutedEventHandler(this.cmdCancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstPrimes = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

