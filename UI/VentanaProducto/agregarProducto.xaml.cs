using CentroNaturistaMasaya.ViewModel;
using System;
using System.Windows;

namespace CentroNaturistaMasaya.UI.VentanaProducto
{
    public partial class agregarProducto : Window
    {
        #region Definición de variables
        public event EventHandler salirDeAgregarProducto;
        #endregion

        #region Constructor de la clase
        public agregarProducto(productoViewModel pVM, bool modificar)
        {
            InitializeComponent();
            DataContext = pVM;
            textoDeVentana(modificar);
            if (modificar)
                pVM.editData(pVM.productoSelected.idProducto);
        }

        private void textoDeVentana(bool modificar)
        {
            if(modificar)
            {
                txtTituloVentana.Text = "Editar producto";
                txtMensajeExito.Text = "Producto editado correctamente";
            }
            else
            {
                txtTituloVentana.Text = "Nuevo Producto";
                txtMensajeExito.Text = "Producto guardado";
            }
        }

        public agregarProducto()
        {
        }
        #endregion
        
        #region Botón Salir
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (salirDeAgregarProducto != null)
                salirDeAgregarProducto(sender, e);
            Close();
        }
        #endregion

        #region Muestra un mensaje de confirmación al guardar los datos
        private void mensaje(object sender, RoutedEventArgs e)
        {
            txtMensajeExito.Visibility = Visibility.Visible;
            btnSalir.Focus();
        }
        private void ocultarMensaje(object sender, RoutedEventArgs e)
        {
            txtMensajeExito.Visibility = Visibility.Hidden;
        }
        #endregion
        
        #region Habilita el boton de guardar luego de que se llenan los campos
        private void habilitarBoton(object sender, RoutedEventArgs e)
        {
            if (validacionCampos())
                btnGuardar.IsEnabled = true;
            else
                btnGuardar.IsEnabled = false;
        }
        #endregion
       
        #region Función auxiliar
        private bool validacionCampos()
        {/*Devuelve true cuando todos los campos tienen datos*/
            bool bandera = false;
            if
                (
                nombreProducto.Text.Trim() != "" &&
                descripcionProducto.Text.Trim() != ""
                )
            {
                bandera = true;
            }
            return bandera;
        }
        #endregion
    }
}
