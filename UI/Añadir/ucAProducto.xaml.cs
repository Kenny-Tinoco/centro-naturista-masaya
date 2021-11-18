using System;
using System.Windows;
using System.Windows.Controls;

namespace CentroNaturistaMasaya.UI.Añadir
{
    public partial class ucAProducto : UserControl
    {
        public event EventHandler btnAtrasAgregarProductoClick;
        public ucAProducto()
        {
            InitializeComponent();
            inicializarSpinBox();
        }

        private void btnAtrasAgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (btnAtrasAgregarProductoClick != null)
                btnAtrasAgregarProductoClick(sender, e);
        }

        private void btnAgregarProducto_T_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnIrAExistencia_Click(object sender, RoutedEventArgs e)
        {
            if (panelBotonAgregar.Visibility != Visibility.Hidden)
                panelBotonAgregar.Visibility = Visibility.Hidden;

        }

        private void inicializarSpinBox()
        {
            buttonSB.ValueChanged += new RoutedPropertyChangedEventHandler<double>(buttonSB_ValueChanged);
            cantidadExistencia.Text = "0";
            buttonSB.Minimum = 0;
            buttonSB.Maximum = 999;
            buttonSB.SmallChange = 1;
        }

        private void buttonSB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cantidadExistencia.Text = buttonSB.Value.ToString();
        }
    }
}
