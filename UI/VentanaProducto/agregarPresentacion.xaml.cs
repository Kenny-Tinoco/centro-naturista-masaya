using System;
using System.Windows;

namespace MasayaNaturistCenter.UI.VentanaProducto
{
    public partial class agregarPresentacion : Window
    {
        #region Definición de variables
        public event EventHandler Salir;
        private bool editable;
        #endregion

        #region Constructor del formulario
        public agregarPresentacion()
        {
            /*Cuando bandera = true, esta ventana será utilizada para editar un elemento*/
            InitializeComponent();
        }
        #endregion

        #region Métodos de los botones 
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (Salir != null)
                Salir(sender, e);
            Close();

        }
        private void mensaje(object sender, RoutedEventArgs e)
        {
            #region Comentario
            /*
             * Muestra un mensaje al momento de dar click al botón guardar.
             * Cuando la instancia de esta ventana es para modificar, al 
             * momento de dar clic en el botón este cierra el ventana de dialogo
             */
            #endregion
            if (editable)
                Close();
            txtMensaje.Visibility = Visibility.Visible;
            bool d = btnSalir.Focus();
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
            if(txtNombre.Text.Trim() != "")
            {
                bandera = true;
            }
            return bandera;
        }
        private void textosDeVentana()
        {
            if (editable)
            {
                txtTituloVentana.Text = "Editar presentación";
            }
            else
            {
                txtTituloVentana.Text = "Nueva Presentación";
                txtMensaje.Text = "Presentación guardada";
            }
        }
        /*Oculta el mensaje de confirmación*/
        private void ocultarMensaje(object sender, RoutedEventArgs e)
        {
            txtMensaje.Visibility = Visibility.Hidden;
        }
        #endregion
    }
}
