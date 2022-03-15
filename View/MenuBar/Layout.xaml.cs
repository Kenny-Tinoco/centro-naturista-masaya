using System.Windows;
using System.Windows.Controls;

namespace MasayaNaturistCenter.View.MenuBar
{
    public partial class Layout : UserControl
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
