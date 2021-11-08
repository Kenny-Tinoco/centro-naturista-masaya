using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CentroNaturistaMasaya.UI
{
    public partial class ucCompra : UserControl
    {
        public event EventHandler btnAtrasCompraClick;
        public ucCompra()
        {
            InitializeComponent();
        }

        private void btnAtrasCompra_Click(object sender, RoutedEventArgs e)
        {
            if (btnAtrasCompraClick != null)
                btnAtrasCompraClick(sender, e);
        }
    }
}
