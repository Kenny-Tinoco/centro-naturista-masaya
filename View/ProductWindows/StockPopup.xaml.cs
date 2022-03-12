using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.ViewModel;
using System.Diagnostics.Contracts;
using System.Windows;

namespace MasayaNaturistCenter.View.ProductWindows
{
    public partial class StockPopup : Window
    {
        private StockDTO stock;
        private StockPopupViewModel popupViewModel;
        
        public StockPopup()
        {
            InitializeComponent();
        }

        public StockPopup(StockPopupViewModel parameter) : this(parameter, new StockDTO())
        {
        }

        public StockPopup(StockPopupViewModel parameter, StockDTO element) : this()
        {
            Contract.Requires(parameter != null);
            popupViewModel = parameter;
            stock = element;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
