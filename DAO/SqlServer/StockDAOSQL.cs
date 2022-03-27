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
    public class StockDAOSQL : BaseDAOSQL, StockDAO
    {

        public StockDAOSQL(MasayaNaturistCenterDataBase parameter) : base(parameter)
        {
            entity = dataBaseContext.Stock;
        }


        public override void create(BaseDTO parameter)
        {
            var element = getStockOf((StockDTO)parameter);
            base.create((BaseDTO)element);
        }

        public override void deleteById(object id)
        {
            var foundStock = findStock((int)id);

            if (foundStock != null)
                base.deleteById(id);
        }     
        
        public override void update( BaseDTO parameter )
        {
            deleteById(((StockDTO)parameter).idStock);
            create(parameter);
        }

        public override List<BaseDTO> getAll()
        {
            return getStockDTOListOf(dataBaseContext.StockView.ToList());
        }

        public override BaseDTO read( object id )
        {
            return getStockDTOof
                (
                    findStock((int)id)
                );
        }

        public List<BaseDTO> getAllOccurrencesOf(string parameter)
        {
            return getStockDTOListOf(getWhere(parameter));
        }



        private List<StockView> getWhere(string parameter)
        {
            Contract.Requires(parameter != null);

            return dataBaseContext
                .StockView
                .Where
                (
                    element => 
                    element.idStock.ToString().Contains(parameter) ||
                    element.name.ToLower().StartsWith(parameter.ToLower()) ||
                    element.presentation.ToLower().StartsWith(parameter.ToLower())

                ).ToList();
        }

        private List<BaseDTO> getStockDTOListOf(List<StockView> stocks)
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
                entryDate = dateUtilities.convertDateToDateTime(parameter.entryDate),
                expiration = dateUtilities.convertDateToDateTime(parameter.expiration)
            };

            return element;
        }

        private StockViewDTO getStockDTOof(StockView parameter)
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

        private StockView findStock(int id)
        {
            var foundElement = 
                dataBaseContext
                .StockView
                .AsNoTracking()
                .SingleOrDefault(element => element.idStock == id);
            
            return foundElement;
        }
    }
}
