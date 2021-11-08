using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CentroNaturistaMasaya.UI
{
    public partial class ucVenta : UserControl
    {

        public event EventHandler btnAtrasVentaClick;

        public ucVenta()
        {
            InitializeComponent();
        }

        private void btnAtrasVenta_Click(object sender, RoutedEventArgs e)
        {
            if (btnAtrasVentaClick != null)
                btnAtrasVentaClick(sender, e);
        }
    }
}
