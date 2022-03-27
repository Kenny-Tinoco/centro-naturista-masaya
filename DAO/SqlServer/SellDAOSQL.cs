using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.DataSource;
using MasayaNaturistCenter.Model.Utilities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class SellDAOSQL : BaseDAOSQL, TransactionDAO
    {
        public SellDAOSQL(MasayaNaturistCenterDataBase parameter) : base(parameter)
        {
            entity = dataBaseContext.Sell;
        }


        public override List<BaseDTO> getAll()
        {
            var list = new List<BaseDTO>();
            var sells = ((ObjectSet<object>)entity).ToList();

            list.AddRange
                (
                    sells
                    .Select(element => getTransactionOf((Sell)element))
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
            var timeUtilities = new TimeUtilities();

            var element = new Sell
            {
                idSell = parameter.idTransaction,
                idEmployee = parameter.idTransactionRelatedObjet,
                date = dateUtilities.convertDateToDateTime(parameter.date),
                total = parameter.total
            };

            return element;
        }

        private TransactionDTO getTransactionOf(Sell parameter)
        {
            var dateUtilities = new DateUtilities();
            var timeUtilities = new TimeUtilities();

            var element = new TransactionDTO
            {
                idTransaction = parameter.idSell,
                idTransactionRelatedObjet = parameter.idEmployee,
                time = timeUtilities.convertDateTimeToTime(parameter.date),
                date = dateUtilities.convertDateTimeToDate(parameter.date),
                total = parameter.total
            };

            return element;
        }
    }
}
