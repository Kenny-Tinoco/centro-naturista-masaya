using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.DataSource;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics.Contracts;
using System;
using System.Linq;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class BaseDAOSQL<Entity> : BaseDAO<BaseDTO, object> where Entity : class
    {
        protected ObjectSet<Entity> entity;
        private MasayaNaturistCenterDataBase _dataBaseContext;


        public BaseDAOSQL( MasayaNaturistCenterDataBase dataBaseContext )
        {
            Contract.Requires(dataBaseContext != null);
            this._dataBaseContext = dataBaseContext;
        }


        public virtual void create( BaseDTO element )
        {
            entity.AddObject(converter(element));
            _dataBaseContext.SaveChanges();
        }

        public virtual void deleteById( object id )
        {
        }

        public virtual List<BaseDTO> getAll()
        {
            return getList(entity.ToList());
        }

        public virtual BaseDTO read( object id )
        {
            throw new NotImplementedException();
        }

        public virtual void update( BaseDTO element )
        {
        }


        public virtual Entity converter( BaseDTO element )
        {
            throw new NotImplementedException();
        }

        public List<BaseDTO> getList( List<Entity> list )
        {
            var presentations = new List<BaseDTO>();

            presentations.AddRange(list.Select(element => convertToDTO(element)).ToList());

            return presentations;
        }

        public virtual BaseDTO convertToDTO( Entity parameter )
        {
            throw new NotImplementedException();
        }
    }
}
