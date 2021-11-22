using CentroNaturistaMasaya.ViewModel;
using System.Windows.Controls;

namespace CentroNaturistaMasaya.UI.Producto
{
    public partial class pProducto : Page
    {
        productoViewModel pVM = new productoViewModel();
        public pProducto()
        {
            InitializeComponent();
            DataContext = pVM;
        }
        private void refrescarDatos()
        {
            pVM.mostrarDatos();
        }
        #region Métodos de los botones
        private void btnAgregar_Click(object sender, System.Windows.RoutedEventArgs e)
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
        { if (txtBusqueda.Text == "") txtBusqueda.Text = "Buscar"; }
        #endregion
    }
}
