using System.Windows;
using System;
using CentroNaturistaMasaya.UI.Producto;
using CentroNaturistaMasaya.UI.Inicio;

namespace CentroNaturistaMasaya
{
    public partial class MainWindow : Window
    {
        #region Constructor de la clase
        public MainWindow()
        {
            InitializeComponent();

            #region Sentencias de para el agrandado de la pantalla
            Width = SystemParameters.WorkArea.Width;
            Height = SystemParameters.WorkArea.Height;
            Top = SystemParameters.WorkArea.Bottom - Height;
            Left = SystemParameters.PrimaryScreenWidth - Width;
            #endregion

            /*Se inicia en la ventana de Inicio*/
            PagesNavigation.Navigate(new Uri("UI/Inicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Eventos de click de los botones de la barra de titulo
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {Close();}
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        { WindowState = WindowState.Minimized;}
        #endregion

        #region Eventos de click en los botones del menú lateral
        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new Uri("UI/Inicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnProducto_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new Uri("UI/Producto/pProducto.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnProveedor_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new Uri("UI/Proveedor/pProveedor.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnEmpleado_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new Uri("UI/Empleado/pEmpleado.xaml", UriKind.RelativeOrAbsolute));
        }
        #endregion
    }
}
