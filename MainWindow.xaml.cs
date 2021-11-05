using CentroNaturistaMasaya.UI;
using System.Windows;
using Microsoft.Toolkit.Mvvm;

namespace CentroNaturistaMasaya
{
    public partial class MainWindow : Window
    {
        ucAñadir    añadir;
        ucHome      home = new ucHome();
        ucModificar modificar;
        ucMostrar   mostrar;

        public MainWindow()
        {
            InitializeComponent();

            /*Sentencias que maximizan la pantalla*/
            Width = SystemParameters.WorkArea.Width;
            Height = SystemParameters.WorkArea.Height;
            Top = SystemParameters.WorkArea.Bottom - Height;
            Left = SystemParameters.PrimaryScreenWidth - Width;

            /*Se inicia en la ventana de home*/
            DataContext = home;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {this.Close();}

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        { WindowState = WindowState.Minimized;}

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            if (añadir == null) añadir = new ucAñadir();
            DataContext = añadir;

            btnHome.Visibility = Visibility.Visible;
        }

        private void btnMostar_Click(object sender, RoutedEventArgs e)
        {
            if (mostrar == null) mostrar = new ucMostrar();
            DataContext = mostrar;
            btnHome.Visibility = Visibility.Visible;
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar == null) modificar = new ucModificar(); 
            DataContext = modificar;
            btnHome.Visibility = Visibility.Visible;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            if (btnHome.Visibility == Visibility.Collapsed)
                btnHome.Visibility = Visibility.Visible;
            else
            {
                DataContext = home;
                btnHome.Visibility = Visibility.Collapsed;
            }

        }
    }
}
