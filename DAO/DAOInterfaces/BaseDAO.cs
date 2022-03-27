using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;

namespace MasayaNaturistCenter.DAO.DAOInterfaces
{
    public interface BaseDAO<T, ID>
    {
        void create( T element );
        BaseDTO read( ID id );
        void update( T element );
        void deleteById( ID id );
        List<T> getAll();
    }
}
