﻿#pragma checksum "..\..\..\..\UI\VentanaPrincipal.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17146BA0FF5403825EC848A7A1D2934C33B05706"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MasayaNaturistCenter;
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


namespace MasayaNaturistCenter {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\UI\VentanaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\UI\VentanaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimizar;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\UI\VentanaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInicio;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\UI\VentanaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProducto;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\UI\VentanaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProveedor;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\UI\VentanaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmpleado;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\..\UI\VentanaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Contenido;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\..\UI\VentanaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PagesNavigation;
        
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
            System.Uri resourceLocater = new System.Uri("/MasayaNaturistCenter;component/ui/ventanaprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\VentanaPrincipal.xaml"
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
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\UI\VentanaPrincipal.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMinimizar = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\UI\VentanaPrincipal.xaml"
            this.btnMinimizar.Click += new System.Windows.RoutedEventHandler(this.btnMinimizar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnInicio = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\..\UI\VentanaPrincipal.xaml"
            this.btnInicio.Click += new System.Windows.RoutedEventHandler(this.btnInicio_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnProducto = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\..\UI\VentanaPrincipal.xaml"
            this.btnProducto.Click += new System.Windows.RoutedEventHandler(this.btnProducto_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnProveedor = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\..\..\UI\VentanaPrincipal.xaml"
            this.btnProveedor.Click += new System.Windows.RoutedEventHandler(this.btnProveedor_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEmpleado = ((System.Windows.Controls.Button)(target));
            
            #line 171 "..\..\..\..\UI\VentanaPrincipal.xaml"
            this.btnEmpleado.Click += new System.Windows.RoutedEventHandler(this.btnEmpleado_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Contenido = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.PagesNavigation = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

