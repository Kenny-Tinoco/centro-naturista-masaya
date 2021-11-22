using System;
using System.Windows.Controls;

namespace CentroNaturistaMasaya.UI.Inicio
{
    public partial class pVenta : Page
    {
        public pVenta()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/Inicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
