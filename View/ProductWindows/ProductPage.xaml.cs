using MasayaNaturistCenter.ViewModel;
using System.Diagnostics.Contracts;
using System.Windows.Controls;

namespace MasayaNaturistCenter.View.ProductWindows
{
    public partial class ProductPage : Page
    {
        public string searchText { get; set; }
        private ProductViewModel productViewModel;

        public ProductPage(ProductViewModel parameter)
        {
            InitializeComponent();
            Contract.Requires(parameter != null);
            productViewModel = parameter;
            DataContext = productViewModel;
        }

        private void SearchBar_SearchBarTextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
