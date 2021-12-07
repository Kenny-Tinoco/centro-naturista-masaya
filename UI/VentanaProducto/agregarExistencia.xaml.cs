using CentroNaturistaMasaya.ViewModel;
using System;
using System.Windows;

namespace CentroNaturistaMasaya.UI.VentanaProducto
{
    public partial class agregarExistencia : Window
    {
        #region Definición de los atributos
        public event EventHandler Salir;
        private bool editable;
        existenciaViewModel eVM;
        #endregion

        #region Constructor de la clase
        public agregarExistencia(existenciaViewModel eVM,  bool bandera)
        {
            InitializeComponent();

            #region Asignación de valores
            if(eVM == null && bandera == false)
            {
                eVM = new existenciaViewModel();
                bandera = true;
            }
            editable = bandera;
            this.eVM = eVM;
            #endregion

            DataContext = eVM;
            cbProducto.SelectedItem = null;

            #region SpinBox
            //this.Loaded += new RoutedEventHandler(NewProjectPlan_Loaded);

            SpinBox.ValueChanged += new RoutedPropertyChangedEventHandler<double>(SpinBox_Value);
            SpinBox.Minimum = 0;
            SpinBox.Maximum = 999;
            SpinBox.SmallChange = 1;
            #endregion
        }
        #endregion

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
        void SpinBox_Value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SpinBox_Text.Text = SpinBox.Value.ToString();
        }

        private void cbProducto_Selected(object sender, RoutedEventArgs e)
        {
            if(cbProducto.SelectedItem != null)
                eVM.productoSeleccionado();
        }

        private void cbPresentacion_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cbPresentacion.SelectedItem != null)
                eVM.presentacionSeleccionado();
        }

    }
}
