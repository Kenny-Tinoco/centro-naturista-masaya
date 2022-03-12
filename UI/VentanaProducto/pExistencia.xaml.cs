using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.ViewModel;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.UI.VentanaProducto
{
    public partial class pExistencia : Page
    {
        public pExistencia()
        {
            InitializeComponent();
        }

        public pExistencia(StockViewModel parameter) : this()
        {
            Contract.Requires(parameter != null);
            DataContext = parameter;
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
        }

        private void mostrarSubVentana(bool modificar)
        {
        }

        private void btnEliminar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void txtBusqueda_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
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
        }

        private void enabledBotones(bool variable)
        {
            btnModificar.IsEnabled = variable;
            btnEliminar.IsEnabled = variable;
        }

        public void Buscar(string dato, bool bandera)
        {
        }

        private void txtBusqueda_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
           
        }

    }
}
