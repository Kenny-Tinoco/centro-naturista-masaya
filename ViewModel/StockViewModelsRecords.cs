using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Logic;
using System.Diagnostics.Contracts;
using System.Collections.Generic;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModelRecords
    {
        public StockLogic logic;
        private IStockDAO stockDAO;


        public StockViewModelRecords(IStockDAO parameter)
        {
            Contract.Requires(parameter != null);
            stockDAO = parameter;
            logic = new StockLogic();
        }


        public List<StockDTO> getAll()
        {
            return stockDAO.getAll();
        }

        public List<StockDTO> getAllOccurrencesOf(string parameter)
        {
            Contract.Requires(parameter != null);
            return stockDAO.getAllOccurrencesOf(parameter);
        }

        public void saveStock()
        {
            stockDAO.add(logic.stock);
        }
    }
}