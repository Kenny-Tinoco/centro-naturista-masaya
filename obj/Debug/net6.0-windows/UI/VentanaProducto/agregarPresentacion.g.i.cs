﻿#pragma checksum "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "615815A494808539345622461AFE3DD96EDC9EA3"
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
    /// agregarPresentacion
    /// </summary>
    public partial class agregarPresentacion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTituloVentana;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMensaje;
        
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
            System.Uri resourceLocater = new System.Uri("/MasayaNaturistCenter;V1.0.0.0;component/ui/ventanaproducto/agregarpresentacion.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
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
            this.txtTituloVentana = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
            this.btnSalir.LostFocus += new System.Windows.RoutedEventHandler(this.ocultarMensaje);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 108 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
            this.txtNombre.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.habilitarBoton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\..\..\..\UI\VentanaProducto\agregarPresentacion.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.mensaje);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtMensaje = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

