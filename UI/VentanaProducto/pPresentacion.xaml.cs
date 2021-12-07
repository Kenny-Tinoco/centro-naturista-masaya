using CentroNaturistaMasaya.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CentroNaturistaMasaya.UI.VentanaProducto
{
    public partial class pPresentacion : Page
    {
        #region Definición de variables
        presentacionViewModel ptVM; 
        #endregion

        #region Constructor de la pagina
        public pPresentacion()
        {
            InitializeComponent();
            ptVM = new presentacionViewModel();
            DataContext = ptVM;
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
        {/*Salir de la ventana agregar presentación*/
            ptVM.resetData();
            ptVM.getAll();
            ptVM.presentacionSelected = null;
        }
        private void mostrarSubVentana(bool modificar)
        {
            agregarPresentacion subVentana = new agregarPresentacion(ptVM, modificar);
            subVentana.Salir += new EventHandler(SalirVAP);
            subVentana.ShowDialog();
        }
        #endregion

        #region Métodos para el estilo del textbox de búsqueda
        private void txtBusqueda_GotFocus(object sender, RoutedEventArgs e)
        {
            dgPresentacion.SelectedItem = null;
            if (txtBusqueda.Text == "Buscar") txtBusqueda.Text = "";
        }
        private void txtBusqueda_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtBusqueda.Text.Trim().Equals("")) txtBusqueda.Text = "Buscar";
        }
        #endregion
        
        #region Método buscar del viewModel
        public void Buscar(string dato, bool bandera)
        {
            if (bandera)
                ptVM.buscarRegistro(dato);
            else
                if (ptVM != null)
                ptVM.getAll();

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
            if (ptVM.presentacionSelected != null)
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
