using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
