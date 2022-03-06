using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.ViewModel;
using System;
using System.Diagnostics.Contracts;
using System.Windows;
using System.Windows.Controls;

namespace MasayaNaturistCenter.View.ProductWindows
{
    public partial class StockPage : Page
    {
        public string searchText { get; set; }
        private StockViewModel stockViewModel;
        

        public StockPage()
        {
            InitializeComponent();
            stockViewModel = new StockViewModel(new StockViewModelRecords(new StockDAO(new Model.Entities.MasayaNaturistCenterDataBase())));
            DataContext = stockViewModel;
            searchText = "";
        }
        

        private void customButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El botón fue presionado");
        }

        private void searchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            search(searchText);
        }

        private void search(string parameter)
        {
            if(validateSearchString(parameter))
            {
                stockViewModel.searchStock(parameter);
            }
        }

        private bool validateSearchString(string parameter)
        {
            Contract.Requires(parameter != null);
            bool ok = true;

            if (parameter.Trim().Equals("Búscar") || parameter.Trim().Equals(""))
            {
                ok = false;
            }

            return ok;
        }
    }
}
