using CentroNaturistaMasaya.UI;
using System.Windows;
using Microsoft.Toolkit.Mvvm;
using System;
using CentroNaturistaMasaya.UI.Añadir;

namespace CentroNaturistaMasaya
{
    public partial class MainWindow : Window
    {
        #region Instancias de los userControls
        ucAñadir añadir;
        ucAProducto aProducto;
        ucCompra compra;
        ucConsulta consulta;
        ucHome home;
        ucModificar modificar;
        ucMostrar mostrar;
        ucVenta venta;
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            #region Sentencias de para el agrandado de la pantalla
            Width = SystemParameters.WorkArea.Width;
            Height = SystemParameters.WorkArea.Height;
            Top = SystemParameters.WorkArea.Bottom - Height;
            Left = SystemParameters.PrimaryScreenWidth - Width;
            #endregion

            #region Suscripciones a los eventos de los botones de ucHome
            home = new ucHome();
            home.btnVentaClick    += new EventHandler(btnVenta_Click);
            home.btnConsultaClick += new EventHandler(btnConsulta_Click);
            home.btnCompraClick   += new EventHandler(btnCompra_Click);
            #endregion

            #region Suscirpciones a los eventos de botones atrás
            #endregion
            /*Se inicia en la ventana de home*/
            DataContext = home;
        }

        #region Eventos de click de los botones de la barra de titulo
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {this.Close();}
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        { WindowState = WindowState.Minimized;}
        #endregion

        #region Eventos de click en los botones del menú lateral
        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            if (añadir == null)
            {
                añadir = new ucAñadir();
                seUcAñadir();
            }
            DataContext = añadir;
            btnHome.Visibility = Visibility.Visible;
        }

        private void btnMostar_Click(object sender, RoutedEventArgs e)
        {
            if (mostrar == null) mostrar = new ucMostrar();
            DataContext = mostrar;
            btnHome.Visibility = Visibility.Visible;
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar == null) modificar = new ucModificar(); 
            DataContext = modificar;
            btnHome.Visibility = Visibility.Visible;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            if (btnHome.Visibility == Visibility.Collapsed)
                btnHome.Visibility = Visibility.Visible;
            else
            {
                DataContext = home;
                btnHome.Visibility = Visibility.Collapsed;
            }
        }
        #endregion

        #region Evento de click en los botones de la ventana home
        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                venta = new ucVenta();
                venta.btnAtrasVentaClick += new EventHandler(btnAtrasVenta_Click);
            }
            DataContext = venta;
            btnHome.Visibility = Visibility.Visible;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (consulta == null)
            {
                consulta = new ucConsulta();
                consulta.btnAtrasConsultaClick += new EventHandler(btnAtrasConsulta_Click);
            }

            DataContext = consulta;
            btnHome.Visibility = Visibility.Visible;
        }
        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (compra == null)
            {
                compra = new ucCompra();
                compra.btnAtrasCompraClick += new EventHandler(btnAtrasCompra_Click);
            }

            DataContext = compra;
            btnHome.Visibility = Visibility.Visible;
        }
        #endregion

        #region Suscripciones a los eventos de los botones de ucAñadir
        private void seUcAñadir() //Suscripción a los eventos en ucAñadir
        {
            añadir.btnAgregarProductoClick += new EventHandler(btnAgregarProducto_Click);
        }
        #endregion
        #region Evento de click en los botones de la ventana Añadir

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (aProducto == null)
            {
                aProducto = new ucAProducto();
                aProducto.btnAtrasAgregarProductoClick += new EventHandler(btnAtrasAgregarProducto_Click);
            }
            DataContext = aProducto;
            btnHome.Visibility = Visibility.Visible;
        }
        #endregion

        #region Evento de click de los botones atrás
        private void btnAtrasVenta_Click(object sender, EventArgs e)
        {
            btnHome_Click(sender, (RoutedEventArgs) e);
        }
        private void btnAtrasConsulta_Click(object sender, EventArgs e)
        {
            btnHome_Click(sender, (RoutedEventArgs)e);
        }
        private void btnAtrasCompra_Click(object sender, EventArgs e)
        {
            btnHome_Click(sender, (RoutedEventArgs)e);
        }
        private void btnAtrasAgregarProducto_Click(object sender, EventArgs e)
        {
            btnAñadir_Click(sender, (RoutedEventArgs)e);
        }
        #endregion

    }
}
