using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MasayaNaturistCenter.UI.VentanaInicio
{
    public partial class pCompra : Page
    {
        public pCompra()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaInicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
