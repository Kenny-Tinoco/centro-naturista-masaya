using System.Windows;
using System.Windows.Controls;

namespace MasayaNaturistCenter.ViewComponents.MenuBar
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
