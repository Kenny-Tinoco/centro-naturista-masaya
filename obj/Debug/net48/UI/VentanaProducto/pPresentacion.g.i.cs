﻿#pragma checksum "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9A5CB350D7EB84954BC1A46D0213DCAF2B19C1D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using CentroNaturistaMasaya.ViewModel;
using MasayaNaturistCenter.UI.VentanaProducto;
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
    /// pPresentacion
    /// </summary>
    public partial class pPresentacion : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAtras;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregar;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBusqueda;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPresentacion;
        
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
            System.Uri resourceLocater = new System.Uri("/MasayaNaturistCenter;V1.0.0.0;component/ui/ventanaproducto/ppresentacion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
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
            this.btnAtras = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
            this.btnAtras.Click += new System.Windows.RoutedEventHandler(this.btnAtras_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
            this.btnAgregar.Click += new System.Windows.RoutedEventHandler(this.btnAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtBusqueda = ((System.Windows.Controls.TextBox)(target));
            
            #line 161 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
            this.txtBusqueda.GotFocus += new System.Windows.RoutedEventHandler(this.txtBusqueda_GotFocus);
            
            #line default
            #line hidden
            
            #line 162 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
            this.txtBusqueda.LostFocus += new System.Windows.RoutedEventHandler(this.txtBusqueda_LostFocus);
            
            #line default
            #line hidden
            
            #line 163 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
            this.txtBusqueda.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBusqueda_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.dgPresentacion = ((System.Windows.Controls.DataGrid)(target));
            
            #line 267 "..\..\..\..\..\UI\VentanaProducto\pPresentacion.xaml"
            this.dgPresentacion.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.HabilitarBotones);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

