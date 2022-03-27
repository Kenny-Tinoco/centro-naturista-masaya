﻿using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DataSource;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class SaleDetailDAOSQL : BaseDAOSQL, TransactionDetailDAO
    {
        public SaleDetailDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.SaleDetail;
        }
    }
}
