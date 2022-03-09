using MasayaNaturistCenter.ViewModel;
using System.Diagnostics.Contracts;
using System.Windows;
using System.Windows.Controls;

namespace MasayaNaturistCenter.View.ProductWindows
{
    public partial class StockPage : Page
    {
        private ProductPage productPage;
        public string searchText { get; set; }

        private StockViewModel stockViewModel;
        

        public StockPage(StockViewModel parameter, ProductPage d)
        {
            InitializeComponent();
            Contract.Requires(parameter != null);
            stockViewModel = parameter;
            DataContext = stockViewModel;
            productPage = d;
        }
        

        private void customButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(productPage);
        }

        private void searchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            stockViewModel.search(searchText);
        }
    }
}
