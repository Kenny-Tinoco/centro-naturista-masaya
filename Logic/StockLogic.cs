using System.Collections.Generic;
using System.Diagnostics.Contracts;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.DAO.DAOInterfaces;

namespace MasayaNaturistCenter.Logic
{
    public class StockLogic : ILogic
    {
        public StockDTO currentStock { get; set; }
        private DAOFactory daoFactory;
        private StockDAO entity;  


        public StockLogic(DAOFactory parameter)
        {
            Contract.Requires(parameter != null);
            daoFactory = parameter;
            entity = daoFactory.stockDAO;
        }


        public List<BaseDTO> getAll()
        {
            return entity.getAll();
        }

        public List<BaseDTO> getAllOccurrencesOf(string parameter)
        {
            Contract.Requires(parameter != null);
            return entity.getAllOccurrencesOf(parameter);
        }

        public void save()
        {
            entity.create(currentStock);
        }

        public void delete(int parameter)
        {
            entity.deleteById(parameter);
        }

        public bool searchLogic(StockViewDTO element, string parameter)
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
