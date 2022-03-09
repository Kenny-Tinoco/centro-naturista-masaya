using MasayaNaturistCenter.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasayaNaturistCenter.Model.DAO
{
    public interface IProductDAO
    {
        void add(ProductDTO parameter);
        void delete(int id);
        void update(ProductDTO parameter);
        List<ProductDTO> getAll();
        List<ProductDTO> getAllOccurrencesOf(string parameter);
    }
}
