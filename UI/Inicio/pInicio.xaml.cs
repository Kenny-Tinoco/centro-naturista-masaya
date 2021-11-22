using System;
using System.Windows;
using System.Windows.Controls;

namespace CentroNaturistaMasaya.UI.Inicio
{
    public partial class pInicio : Page
    {        
        public pInicio()
        {
            InitializeComponent();
        }

        private void btnVenta_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/Inicio/pVenta.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/Inicio/pConsulta.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnCompra_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/Inicio/pCompra.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
