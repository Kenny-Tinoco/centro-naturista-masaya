﻿#pragma checksum "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39EA530A495B4C38D00F92E2988B468F6819088B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace MasayaNaturistCenter.UI.VentanaProducto {
    
    
    /// <summary>
    /// pExistencia
    /// </summary>
    public partial class pExistencia : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 70 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProducto;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPresentacion;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarExistencia;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBusqueda;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 230 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgProducto;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MasayaNaturistCenter;V1.0.0.0;component/ui/ventanaproducto/pexistencia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnProducto = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.btnProducto.Click += new System.Windows.RoutedEventHandler(this.btnProducto_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnPresentacion = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.btnPresentacion.Click += new System.Windows.RoutedEventHandler(this.btnPresentacion_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAgregarExistencia = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.btnAgregarExistencia.Click += new System.Windows.RoutedEventHandler(this.AgregarExistencia);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 187 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.txtBusqueda.GotFocus += new System.Windows.RoutedEventHandler(this.txtBusqueda_GotFocus);
            
            #line default
            #line hidden
            
            #line 188 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.txtBusqueda.LostFocus += new System.Windows.RoutedEventHandler(this.txtBusqueda_LostFocus);
            
            #line default
            #line hidden
            
            #line 189 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.txtBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            
            #line 189 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.txtBusqueda.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtBusqueda_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 207 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 234 "..\..\..\..\..\UI\VentanaProducto\pExistencia.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgProducto = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

