using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;

namespace MasayaNaturistCenter.DAO.DAOInterfaces
{
    public interface BaseDAO
    {
        void create(object element);
        BaseDTO read(object id);
        void update(object element);
        void deleteById(object id);
        List<BaseDTO> getAll();
    }
}
