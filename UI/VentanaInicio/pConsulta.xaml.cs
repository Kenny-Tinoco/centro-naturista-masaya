using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace CentroNaturistaMasaya.UI.VentanaInicio
{
    public partial class pConsulta : Page
    {
        public pConsulta()
        {
            InitializeComponent();
        }
        private void btnAtras_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/VentanaInicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
