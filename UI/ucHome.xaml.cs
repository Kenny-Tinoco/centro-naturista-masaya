using System;
using System.Windows;
using System.Windows.Controls;

namespace CentroNaturistaMasaya.UI
{
    public partial class ucHome : UserControl
    {
        public event EventHandler btnVentaClick;
        public event EventHandler btnConsultaClick;
        public event EventHandler btnCompraClick;

        public ucHome()
        {
            InitializeComponent();
        }

        private void btnVenta_Click(object sender, RoutedEventArgs e)
        {
            if (btnVentaClick != null)
                btnVentaClick(this, e);
        }

        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            if (btnConsultaClick != null)
                btnConsultaClick(this, e);
        }

        private void btnCompra_Click(object sender, RoutedEventArgs e)
        {
            if (btnCompraClick != null)
                btnCompraClick(this, e);
        }
    }
}
