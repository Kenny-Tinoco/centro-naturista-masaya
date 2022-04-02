using System.Diagnostics.Contracts;
using System.Data.Entity.Core.Objects;
using DataAccess.Model.DataSource;
using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DTO;

namespace DataAccess.DAO.SqlServer
{
    public abstract class BaseDAOSQL<Entity, GenericDTO> : BaseDAO<GenericDTO, object> 
        where Entity : class 
        where GenericDTO : BaseDTO
    {
        protected ObjectSet<Entity> entity;
        private readonly MasayaNaturistCenterDataBase _dataBaseContext;


        public BaseDAOSQL( MasayaNaturistCenterDataBase dataBaseContext )
        {
            Contract.Requires(dataBaseContext != null);
            _dataBaseContext = dataBaseContext;
        }


        public virtual async Task create( GenericDTO element )
        {
            entity.AddObject(converter(element));
            //await _dataBaseContext.SaveChangesAsync();

        }

        public virtual async Task deleteById( object id )
        {
            entity.DeleteObject(converter(await read(id)));
        }

        public virtual async Task<IEnumerable<GenericDTO>> getAll()
        {
            return getList(entity.ToList());
        }

        public virtual async Task<GenericDTO> read( object id )
        {
            throw new NotImplementedException();
        }

        public virtual async Task update( GenericDTO element )
        {
            throw new NotImplementedException();
        }



        public virtual Entity converter( GenericDTO parameter )
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenericDTO> getList( IEnumerable<Entity> list )
        {
            return list.Select(element => convertToDTO(element));
        }

        public virtual GenericDTO convertToDTO( Entity parameter )
        {
            throw new NotImplementedException();
        }

    }
}
