using CentroNaturistaMasaya.ViewModel;
using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace CentroNaturistaMasaya.UI.VentanaProducto
{
    public partial class pExistencia : Page
    {
        existenciaViewModel eVM = new existenciaViewModel();
        public pExistencia()
        {
            InitializeComponent();
            DataContext = eVM;
        }
        private void refrescarDatos()
        {
            eVM.mostrarDatos();
        }
        #region Métodos de los botones
        private void btnProducto_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaProducto/pProducto.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnAgregar_Click(object sender, System.Windows.RoutedEventArgs e)/*Agregar Existencia*/
        {

        }

        private void btnModificar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            refrescarDatos();
        }

        private void btnEliminar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            refrescarDatos();
        }
        #endregion
        #region Estilo del text para el cuadro de búsqueda
        private void txtBusqueda_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        { if (txtBusqueda.Text == "Buscar") txtBusqueda.Text = ""; }
        private void txtBusqueda_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        { if (txtBusqueda.Text.Trim().Equals("")) txtBusqueda.Text = "Buscar"; }
        #endregion

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (
                !txtBusqueda.Text.Trim().Equals("Buscar") &&
                !txtBusqueda.Text.Trim().Equals("")
                )
            {
                eVM.buscarRegistro(txtBusqueda.Text.Trim());
            }
            else
            {
                refrescarDatos();
            }
        }

        private void txtBusqueda_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
    }
}
