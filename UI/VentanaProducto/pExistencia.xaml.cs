using CentroNaturistaMasaya.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace CentroNaturistaMasaya.UI.VentanaProducto
{
    public partial class pExistencia : Page
    {
        #region Definición de las variables
        existenciaViewModel eVM;
        #endregion

        #region Constructor de la página
        public pExistencia()
        {
            InitializeComponent();
            eVM = new existenciaViewModel();
            DataContext = eVM;
        }
        #endregion

        #region Métodos de los botones
        private void btnProducto_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaProducto/pProducto.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnPresentacion_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaProducto/pPresentacion.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnAgregar_Click(object sender, System.Windows.RoutedEventArgs e)/*Agregar Existencia*/
        {
            mostrarSubVentana(false);
        }

        private void btnModificar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            mostrarSubVentana(true);
        }
        private void SalirVAP(object sender, EventArgs e)
        {/*Salir de la ventana agregar producto*/
            eVM.resetData();
            eVM.getAll();
            dgProducto.SelectedItem = null;
        }
        private void mostrarSubVentana(bool modificar)
        {
            agregarExistencia subVentana = new agregarExistencia(eVM, modificar);
            subVentana.Salir += new EventHandler(SalirVAP);
            subVentana.ShowDialog();
        }

        private void btnEliminar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }
        #endregion
        
        #region Métodos para el estilo del textbox de búsqueda
        private void txtBusqueda_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            eVM.existenciaSelected = null;
            if (txtBusqueda.Text == "Buscar") txtBusqueda.Text = "";
        }
        private void txtBusqueda_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        { if (txtBusqueda.Text.Trim().Equals("")) txtBusqueda.Text = "Buscar"; }
        #endregion

        #region Métodos auxialires
        private bool validadorBarraDeBusqueda()
        {
            bool bandera = false;
            if (
                !txtBusqueda.Text.Trim().Equals("Buscar") &&
                !txtBusqueda.Text.Trim().Equals("")
                )
                bandera = true;
            return bandera;
        }
        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            Buscar(txtBusqueda.Text.Trim(), validadorBarraDeBusqueda());
        }
        private void HabilitarBotones(object sender, RoutedEventArgs e)
        {
            if (eVM.existenciaSelected != null)
                enabledBotones(true);
            else
                enabledBotones(false);
        }
        private void enabledBotones(bool variable)
        {
            btnModificar.IsEnabled = variable;
            btnEliminar.IsEnabled = variable;
        }
        #endregion

        #region Método buscar del viewModel
        public void Buscar(string dato, bool bandera)
        {
            if (bandera)
                eVM.buscarRegistro(dato);
            else
                if (eVM != null)
                eVM.getAll();

        }
        #endregion

        private void txtBusqueda_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

    }
}
