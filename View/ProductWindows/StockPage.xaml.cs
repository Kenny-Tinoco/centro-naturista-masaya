using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MasayaNaturistCenter.View.ProductWindows
{
    public partial class StockPage : Page
    {
        private ProductPage productPage;

        private StockViewModel stockViewModel;


        public StockPage(StockViewModel parameter, ProductPage d)
        {
            InitializeComponent();

            Contract.Requires(parameter != null);
            stockViewModel = parameter;
            DataContext = stockViewModel;

            stockViewModel.dataGridSource = (CollectionViewSource)Resources["DataGridSource"];
            productPage = d;
        }
        

        private void product_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(productPage);
        }

        private void searchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            stockViewModel.search();
        }

        private void presentation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addStock_Click(object sender, RoutedEventArgs e)
        {
            StockPopup stockPopup = new StockPopup();
            stockPopup.ShowDialog();
        }
    }
}
