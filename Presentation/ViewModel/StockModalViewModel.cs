using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Utilities;
using MasayaNaturistCenter.Services;
using System;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockModalViewModel : ViewModelBase
    {
        public StockDTO stock { get; set; } 
        public StockDTO productoRecord { get; set; }
        public DateTime dateConvertExpiration 
        { 
            get
            {
                return new DateUtilities().convertDateToDateTime(stock.expiration);
            }
            set
            {
                stock.expiration = new DateUtilities().convertDateTimeToDate(value);
            }
        }

        public DateTime dateConvertEntryDate
        {
            get
            {
                return new DateUtilities().convertDateToDateTime(stock.entryDate);
            }
            set
            {
                stock.entryDate = new DateUtilities().convertDateTimeToDate(value);
            }
        }


        public string titleBar { get; }

        public ICommand exitCommand { get; }
        public ICommand saveCommand { get; }

        public StockModalViewModel( INavigationService stockModalNavigationService, BaseDTO elementDTO)
        {
            stock = elementDTO as StockDTO;
            productoRecord = new StockDTO();
            exitCommand = new ExitModalCommand(stockModalNavigationService);
            titleBar = "Agregar Existencia";
        }
    }
}
