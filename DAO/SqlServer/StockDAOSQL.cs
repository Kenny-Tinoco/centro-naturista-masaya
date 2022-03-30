using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.DataSource;
using MasayaNaturistCenter.Model.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class StockDAOSQL : BaseDAOSQL<StockView>, StockDAO
    {

        public StockDAOSQL(MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.StockView;
        }

        private List<StockView> getWhere(string parameter)
        {
            Contract.Requires(parameter != null);

            return entity
                .Where
                (
                    element => 
                    element.idStock.ToString().Contains(parameter) ||
                    element.name.ToLower().StartsWith(parameter.ToLower()) ||
                    element.presentation.ToLower().StartsWith(parameter.ToLower())

                ).ToList();
        }


        private Stock getStockOf(StockDTO parameter)
        {
            var dateUtilities = new DateUtilities();

            var element = new Stock
            {
                idStock = parameter.idStock,
                idProduct = parameter.idProduct,
                idPresentation = parameter.idPresentation,
                quantity = parameter.quantity,
                price = parameter.price,
                entryDate = dateUtilities.convertDateToDateTime(parameter.entryDate),
                expiration = dateUtilities.convertDateToDateTime(parameter.expiration)
            };

            return element;
        }

  

        public override BaseDTO convertToDTO( StockView parameter )
        {
            var element = new StockViewDTO
            {
                idStock = parameter.idStock,
                name = parameter.name,
                description = parameter.description,
                presentation = parameter.presentation,
                quantity = parameter.quantity,
                price = parameter.price,
                entryDate = parameter.entryDate,
                expiration = parameter.expiration
            };

            return element;
        }
    }
}
