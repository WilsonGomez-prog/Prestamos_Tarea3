﻿#pragma checksum "..\..\..\..\..\UI\Registros\rPrestamo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34E49DE3C79CFB47B450B92D426F46D4B433003C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Prestamos_Tarea3;
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


namespace Prestamos_Tarea3.UI.Registros {
    
    
    /// <summary>
    /// rPrestamo
    /// </summary>
    public partial class rPrestamo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrestamoIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuscarButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaPrestamoDP;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PersonaIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConceptoTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MontoTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BalanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NuevoButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuardarButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EliminarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Prestamos_Tarea3;component/ui/registros/rprestamo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PrestamoIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BuscarButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            this.BuscarButton.Click += new System.Windows.RoutedEventHandler(this.BuscarButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FechaPrestamoDP = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.PersonaIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ConceptoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MontoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BalanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.NuevoButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            this.NuevoButton.Click += new System.Windows.RoutedEventHandler(this.NuevoButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.GuardarButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            this.GuardarButton.Click += new System.Windows.RoutedEventHandler(this.GuardarButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EliminarButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            this.EliminarButton.Click += new System.Windows.RoutedEventHandler(this.EliminarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

