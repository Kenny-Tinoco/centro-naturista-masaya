using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MasayaNaturistCenter.UI.VentanaInicio
{
    public partial class pInicio : Page
    {
        public pInicio()
        {
            InitializeComponent();
        }

        private void btnVenta_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaInicio/pVenta.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaInicio/pConsulta.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnCompra_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaInicio/pCompra.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
