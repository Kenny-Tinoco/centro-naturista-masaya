using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Entities;
using MasayaNaturistCenter.Model.Utilities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;

namespace MasayaNaturistCenter.Model.DAO
{
    public class SellDAO : ITransaction
    {
        private MasayaNaturistCenterDataBase dataBaseContext;


        public SellDAO(MasayaNaturistCenterDataBase parameter)
        {
            Contract.Requires(parameter != null);
            dataBaseContext = parameter;
        }


        public void add(TransactionDTO parameter)
        { 
            dataBaseContext.Sell.AddObject(getSellOf(parameter));
            dataBaseContext.SaveChanges();
        }

        public void delete(int id)
        {
            var element = findTransaction(id);

            if(element != null)
            {
                dataBaseContext.Sell.DeleteObject((Sell)element);
                dataBaseContext.SaveChanges();
            }
        }

        public void update(TransactionDTO parameter)
        {
            delete(parameter.idTransaction);
            add(parameter);
        }

        public TransactionDTO get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<TransactionDTO> getAll()
        {
            var list = new List<TransactionDTO>();
            var sells = dataBaseContext.Sell.ToList();

            list.AddRange
                (
                    sells
                    .Select(element => getTransactionOf(element))
                    .ToList()
                );

            return list;
        }

        public object findTransaction(int id)
        {
            var foundElement =
                dataBaseContext
                .Sell
                .AsNoTracking()
                .SingleOrDefault(element => element.idSell == id);

            return foundElement;
        }


        private Sell getSellOf(TransactionDTO parameter)
        {
            var dateUtilities = new DateUtilities();
            var timeUtilities = new TimeUtilites();

            var element = new Sell
            {
                idSell = parameter.idTransaction,
                idEmployee = parameter.idTransactionRelatedObjet,
                time = timeUtilities.convertTimeToString(parameter.time),
                date = dateUtilities.convertDateToString(parameter.date),
                total = parameter.total
            };

            return element;
        }

        private TransactionDTO getTransactionOf(Sell parameter)
        {
            var dateUtilities = new DateUtilities();
            var timeUtilities = new TimeUtilites();

            var element = new TransactionDTO
            {
                idTransaction = parameter.idSell,
                idTransactionRelatedObjet = parameter.idEmployee,
                time = timeUtilities.convertStringToTime(parameter.time),
                date = dateUtilities.convertStringToDate(parameter.date),
                total = parameter.total
            };

            return element;
        }
    }
}
