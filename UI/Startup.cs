using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.Entities;
using MasayaNaturistCenter.UI.VentanaProducto;
using MasayaNaturistCenter.View.ProductWindows;
using MasayaNaturistCenter.ViewModel;
using System;
using System.Windows;

namespace MasayaNaturistCenter
{
    public partial class Startup : Window
    {
        #region Constructor de la clase
        public Startup()
        {
            InitializeComponent();

            MaximizarVentana();

            /*Se inicia en la ventana de Inicio*/
            PagesNavigation.Navigate(new Uri("UI/VentanaInicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MaximizarVentana()
        {
            #region Sentencias de para el agrandado de la pantalla
            Width = SystemParameters.WorkArea.Width;
            Height = SystemParameters.WorkArea.Height;
            Top = SystemParameters.WorkArea.Bottom - Height;
            Left = SystemParameters.PrimaryScreenWidth - Width;
            #endregion
        }

        public Startup(StockPage o)
        {
            InitializeComponent();
            MaximizarVentana();
            PagesNavigation.Navigate(o);
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
            //PagesNavigation.Navigate(new Uri("UI/VentanaProducto/pExistencia.xaml", UriKind.RelativeOrAbsolute));
            var pStock = new pExistencia(new StockViewModel(new StockViewModelRecords(new StockDAO(new MasayaNaturistCenterDataBase()))));
            PagesNavigation.Navigate(pStock);
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
