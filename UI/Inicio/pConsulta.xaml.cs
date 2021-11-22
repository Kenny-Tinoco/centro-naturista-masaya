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

namespace CentroNaturistaMasaya.UI.Inicio
{
    public partial class pConsulta : Page
    {
        public pConsulta()
        {
            InitializeComponent();
        }
        private void btnAtras_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("UI/Inicio/pInicio.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
