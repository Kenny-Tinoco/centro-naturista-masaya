using DataAccess.SqlServerDataSource;
using WPF.Command;
using WPF.Services;
using System.Windows.Input;

namespace WPF.ViewModel
{
    public class StockModalViewModel : ViewModelBase
    {
        public Stock stock { get; set; } 
        public Stock productoRecord { get; set; }


        public string titleBar { get; }

        public ICommand exitCommand { get; }
        public ICommand saveCommand { get; }

        public StockModalViewModel( INavigationService stockModalNavigationService, BaseEntity elementDTO)
        {
            stock = elementDTO as Stock;
            productoRecord = new Stock();
            exitCommand = new ExitModalCommand(stockModalNavigationService);
            titleBar = "Agregar Existencia";
        }
    }
}
