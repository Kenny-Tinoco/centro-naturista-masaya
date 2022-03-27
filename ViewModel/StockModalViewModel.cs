using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Services;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockModalViewModel : ViewModelBase
    {
        public StockDTO stock { get; } 
        public StockDTO productoRecord { get; set; }
        public string titleBar { get; }

        public ICommand exitCommand { get; }
        public ICommand saveCommand { get; }

        public StockModalViewModel( INavigationService stockModalNavigationService )
        {
            stock = new StockDTO();
            productoRecord = new StockDTO();
            exitCommand = new ExitModalCommand(stockModalNavigationService);
            titleBar = "Agregar Existencia";
        }
    }
}
