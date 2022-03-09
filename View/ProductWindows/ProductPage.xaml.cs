using MasayaNaturistCenter.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace MasayaNaturistCenter.View.ProductWindows
{
    public partial class ProductPage : Page
    {
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
