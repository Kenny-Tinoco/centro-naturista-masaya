namespace MasayaNaturistCenter.DAO.DAOInterfaces
{
    public abstract class DAOFactory
    {
        public virtual StockDAO stockDAO { get; }

        public virtual ConsultDAO getConsultDAO() 
        { 
            return null; 
        }

        public virtual ProductDAO getProductDAO()
        { 
            return null;
        }

    }
}
