using MasayaNaturistCenter.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MasayaNaturistCenter.UI.VentanaProducto
{
    public partial class pExistencia : Page
    {
        existenciaViewModel eVM;


        public pExistencia()
        {
            InitializeComponent();
            eVM = new existenciaViewModel();
            DataContext = eVM;
        }


        private void btnProducto_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaProducto/pProducto.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnPresentacion_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaProducto/pPresentacion.xaml", UriKind.RelativeOrAbsolute));
        }

        private void AgregarExistencia(object sender, System.Windows.RoutedEventArgs e)
        {
            mostrarSubVentana(false);
        }

        private void btnModificar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            mostrarSubVentana(true);
        }

        private void SalirVentanaAgregarProducto(object sender, EventArgs e)
        {
            eVM.resetData();
            eVM.getAll();
            dgProducto.SelectedItem = null;
        }

        private void mostrarSubVentana(bool modificar)
        {
            agregarExistencia subVentana = new agregarExistencia(eVM, modificar);
            subVentana.Salir += new EventHandler(SalirVentanaAgregarProducto);
            subVentana.ShowDialog();
        }

        private void btnEliminar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void txtBusqueda_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            eVM.existenciaSelected = null;
            if (txtBusqueda.Text == "Buscar") txtBusqueda.Text = "";
        }

        private void txtBusqueda_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        { 
            if (txtBusqueda.Text.Trim().Equals("")) txtBusqueda.Text = "Buscar"; 
        }

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

        public void Buscar(string dato, bool bandera)
        {
            if (bandera)
                eVM.buscarRegistro(dato);
            else
                if (eVM != null)
                eVM.getAll();

        }

        private void txtBusqueda_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

    }
}
