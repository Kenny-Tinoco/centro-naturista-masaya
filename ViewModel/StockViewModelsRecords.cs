using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Logic;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using MasayaNaturistCenter.ViewModel.Services;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModelRecords
    {
        public StockLogic logic;
        public INavigationService navigationService;
        private IStockDAO stockDAO;


        public StockViewModelRecords(IStockDAO parameter, INavigationService navigationService)
        {
            Contract.Requires(parameter != null);
            stockDAO = parameter;
            this.navigationService = navigationService;
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

        public void deleteStock(int parameter)
        {
            stockDAO.delete(parameter);
        }

        public bool searchLogic(StockDTO element, string parameter)
        {
            Contract.Requires(parameter != null && element != null);
            bool ok = false;

            if
            (
                element.idStock.ToString().Contains(parameter.Trim()) ||
                element.name.ToLower().StartsWith(parameter.Trim().ToLower()) ||
                element.presentation.ToLower().StartsWith(parameter.Trim().ToLower())
            )
            {
                ok = true;
            }

            return ok;
        }
    }
}