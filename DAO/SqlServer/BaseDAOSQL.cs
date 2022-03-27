using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.DataSource;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class BaseDAOSQL : BaseDAO<BaseDTO, object>
    {
        protected object entity;
        protected MasayaNaturistCenterDataBase dataBaseContext;


        public BaseDAOSQL(MasayaNaturistCenterDataBase dataBaseContext)
        {
            Contract.Requires(dataBaseContext != null);
            this.dataBaseContext = dataBaseContext;
        }


        public virtual void create(BaseDTO element)
        {
            ((ObjectSet<object>)entity).AddObject(element);
            dataBaseContext.SaveChanges();
        }

        public virtual void deleteById(object id)
        {
            ((ObjectSet<object>)entity).DeleteObject(id);
            dataBaseContext.SaveChanges();
        }

        public virtual List<BaseDTO> getAll()
        {
            return null;
        }

        public virtual BaseDTO read(object id)
        {
            return null;
        }

        public virtual void update( BaseDTO element )
        {
        }
    }
}
