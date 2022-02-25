using System;
using System.Windows;

namespace MasayaNaturistCenter
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
            PagesNavigation.Navigate(new Uri("UI/VentanaInicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
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
            PagesNavigation.Navigate(new Uri("UI/VentanaInicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnProducto_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new Uri("UI/VentanaProducto/pExistencia.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnProveedor_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new Uri("UI/VentanaProveedor/pProveedor.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnEmpleado_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new Uri("UI/VentanaEmpleado/pEmpleado.xaml", UriKind.RelativeOrAbsolute));
        }
        #endregion
    }
}
