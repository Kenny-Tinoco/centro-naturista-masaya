using CentroNaturistaMasaya.UI;
using System.Windows;

namespace CentroNaturistaMasaya
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*Sentencias que maximizan la pantalla*/
            Width = SystemParameters.WorkArea.Width;
            Height = SystemParameters.WorkArea.Height;
            Top = SystemParameters.WorkArea.Bottom - Height;
            Left = SystemParameters.PrimaryScreenWidth - Width;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {this.Close();}

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        { WindowState = WindowState.Minimized;}

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ucAñadir();
        }

        private void btnMostar_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ucMostrar();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ucModificar();
        }
    }
}
