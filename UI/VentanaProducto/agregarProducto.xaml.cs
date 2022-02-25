using System;
using System.Windows;

namespace MasayaNaturistCenter.UI.VentanaProducto
{
    public partial class agregarProducto : Window
    {
        #region Definición de variables
        public event EventHandler Salir;
        private bool editable;
        #endregion

        #region Constructor de la clase
        public agregarProducto()
        {
            InitializeComponent();
        }
        #endregion
        
        #region Botón Salir
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (Salir != null)
                Salir(sender, e);
            Close();
        }
        #endregion

        #region Muestra un mensaje de confirmación al guardar los datos
        private void mensaje(object sender, RoutedEventArgs e)
        {
            if (editable) Close(); 
            txtMensaje.Visibility = Visibility.Visible;
            btnSalir.Focus();
        }
        private void ocultarMensaje(object sender, RoutedEventArgs e)
        {
            txtMensaje.Visibility = Visibility.Hidden;
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
       
        #region Funciones auxiliares
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
        private void textoDeVentana()
        {
            if (editable)
            {
                txtTituloVentana.Text = "Editar producto";
            }
            else
            {
                txtTituloVentana.Text = "Nuevo Producto";
                txtMensaje.Text = "Producto guardado";
            }
        }
        #endregion
    }
}
