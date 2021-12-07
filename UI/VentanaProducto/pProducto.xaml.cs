using CentroNaturistaMasaya.Model;
using CentroNaturistaMasaya.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace CentroNaturistaMasaya.UI.VentanaProducto
{
    public partial class pProducto : Page
    {
        #region Definición de las variables
        productoViewModel pVM;
        #endregion
        #region Constructor de la clase
        public pProducto()
        {
            InitializeComponent();
            pVM = new productoViewModel();
            DataContext = pVM;
        }
        #endregion
        #region Métodos de los botones
        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaProducto/pExistencia.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            mostrarSubVentana(false);
        }
        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            mostrarSubVentana(true);
        }
        private void SalirVAP(object sender, EventArgs e)
        {/*Salir de la ventana agregar producto*/
            pVM.resetData();
            pVM.getAll();
            dgProducto.SelectedItem = null;
        }
        private void mostrarSubVentana(bool modificar)
        {
            agregarProducto subVentana = new agregarProducto(pVM, modificar);
            subVentana.Salir += new EventHandler(SalirVAP);
            subVentana.ShowDialog();
        }
        #endregion
        #region Estilo del text para el cuadro de búsqueda
        private void txtBusqueda_GotFocus(object sender, RoutedEventArgs e)
        {
            dgProducto.SelectedItem = null;
            if (txtBusqueda.Text == "Buscar") txtBusqueda.Text = ""; 
        }

        private void txtBusqueda_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtBusqueda.Text.Trim().Equals("")) txtBusqueda.Text = "Buscar";
        }
        #endregion
        #region Métodos buscar del viewModel
        public void Buscar(string dato, bool bandera)
        {
            if (bandera)
                pVM.buscarRegistro(dato);
            else
                if(pVM != null)
                pVM.getAll();

        }
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
            if (dgProducto.SelectedItem != null)
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

    }
}
