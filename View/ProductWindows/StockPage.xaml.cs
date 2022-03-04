using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.Entities;
using MasayaNaturistCenter.ViewModel;
using System.Windows.Controls;

namespace MasayaNaturistCenter.View.ProductWindows
{
    public partial class StockPage : Page
    {
        public StockViewModel stockViewModel;
        public StockPage()
        {
            InitializeComponent();
            stockViewModel = new StockViewModel(new StockViewModelRecords(new StockDAO(new MasayaNaturistCenterDataBase())));
            DataContext = stockViewModel;
        }
    }
}
