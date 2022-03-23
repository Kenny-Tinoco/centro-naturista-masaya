using System.Collections.Generic;
using System.Diagnostics.Contracts;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.DAO.DAOInterfaces;

namespace MasayaNaturistCenter.X
{
    public class StockX : IX
    {
        public StockDTO currentStock { get; set; }
        private DAOFactory daoFactory;


        public StockX(DAOFactory parameter)
        {
            Contract.Requires(parameter != null);
            daoFactory = parameter;
        }


        public List<BaseDTO> getAll()
        {
            return daoFactory.stockDAO.getAll();
        }

        public List<BaseDTO> getAllOccurrencesOf(string parameter)
        {
            Contract.Requires(parameter != null);
            return daoFactory.stockDAO.getAllOccurrencesOf(parameter);
        }

        public void saveStock()
        {
            daoFactory.stockDAO.create(currentStock);
        }

        public void deleteStock(int parameter)
        {
            daoFactory.stockDAO.deleteById(parameter);
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
