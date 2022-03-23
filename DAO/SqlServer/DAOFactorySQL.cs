using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.Entities;
using System;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class DAOFactorySQL : DAOFactory
    {
        private MasayaNaturistCenterDataBase dataBaseContext;

        private ConsultDAO consultDAO;
        private ProductDAO productDAO;
        private StockDAO _stockDAO;


        public DAOFactorySQL(MasayaNaturistCenterDataBase dataBaseContext)
        {
            Contract.Requires(dataBaseContext != null);
            this.dataBaseContext = dataBaseContext;
        }

        public override ConsultDAO getConsultDAO()
        {
            if(consultDAO == null)
                consultDAO = new ConsultDAOSQL(dataBaseContext);

            return consultDAO;
        }

        public override ProductDAO getProductDAO()
        {
            if (productDAO == null)
                productDAO = new ProductDAOSQL(dataBaseContext);

            return productDAO;
        }

        public override StockDAO stockDAO
        {
            get 
            {
                if (_stockDAO == null)
                    _stockDAO = new StockDAOSQL(dataBaseContext);

                return _stockDAO; 
            }
        }
    }
}
