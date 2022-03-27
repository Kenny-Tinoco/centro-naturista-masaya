using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;

namespace MasayaNaturistCenter.DAO.DAOInterfaces
{
    public interface ProductDAO : BaseDAO<BaseDTO, object>
    {
        List<ProductDTO> getAllOccurrencesOf(string parameter);
    }
}
