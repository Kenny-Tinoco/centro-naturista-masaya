using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Entities;
using MasayaNaturistCenter.Model.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class StockDAOSQL : BaseDAOSQL, StockDAO
    {
        public StockDAOSQL(MasayaNaturistCenterDataBase parameter) :  base(parameter)
        {
            entity = dataBaseContext.Stock;
        }

        public override void create(object parameter)
        {
            var element = getStockOf((StockDTO)parameter);
            base.create(element);
        }

        public override void deleteById(object id)
        {
            var foundStock = findStock((int)id);

            if (foundStock != null)
                base.deleteById(id);
        }     
        
        public override void update(object parameter)
        {
            deleteById(((StockDTO)parameter).idStock);
            create(parameter);
        }

        public override List<BaseDTO> getAll()
        {
            return getStockDTOListOf(dataBaseContext.Stock.ToList());
        } 
        
        public List<BaseDTO> getAllOccurrencesOf(string parameter)
        {
            return getStockDTOListOf(getWhere(parameter));
        }



        private List<Stock> getWhere(string parameter)
        {
            Contract.Requires(parameter != null);

            return dataBaseContext
                .Stock
                .Where
                (
                    element => 
                    element.idStock.ToString().Contains(parameter) ||
                    element.Product.name.ToLower().StartsWith(parameter.ToLower()) ||
                    element.Presentation.name.ToLower().StartsWith(parameter.ToLower())

                ).ToList();
        }

        private List<BaseDTO> getStockDTOListOf(List<Stock> stocks)
        {
            var list = new List<BaseDTO>();

            list.AddRange(stocks.Select(element => getStockDTOof(element)).ToList());

            return list;
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
                entryDate = dateUtilities.convertDateToString(parameter.entryDate),
                expiration = dateUtilities.convertDateToString(parameter.expiration)
            };

            return element;
        }

        private StockDTO getStockDTOof(Stock parameter)
        {
            var dateUtilities = new DateUtilities();

            var element = new StockDTO
            {
                idStock = parameter.idStock,
                idProduct = parameter.idProduct,
                name = parameter.Product.name,
                description = parameter.Product.description,
                idPresentation = parameter.idPresentation,
                presentation = parameter.Presentation.name,
                quantity = parameter.quantity,
                price = parameter.price,
                entryDate = dateUtilities.convertStringToDate(parameter.entryDate),
                expiration = dateUtilities.convertStringToDate(parameter.expiration)
            };

            return element;
        }

        private Stock findStock(int id)
        {
            var foundElement = 
                dataBaseContext
                .Stock
                .AsNoTracking()
                .SingleOrDefault(element => element.idStock == id);
            
            return foundElement;
        }
    }
}
