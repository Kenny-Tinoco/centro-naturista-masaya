
using System;
using System.Windows;

namespace MasayaNaturistCenter.UI.VentanaProducto
{
    public partial class agregarExistencia : Window
    {
        public event EventHandler Salir;


        public agregarExistencia()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (Salir != null)
                Salir(sender, e);
            Close();
        }

        private void mensaje(object sender, RoutedEventArgs e)
        {

        }

        private void ocultarMensaje(object sender, RoutedEventArgs e)
        {

        }

        private void cbProducto_Selected(object sender, RoutedEventArgs e)
        {
        }

        private void cbPresentacion_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        }

    }
}
