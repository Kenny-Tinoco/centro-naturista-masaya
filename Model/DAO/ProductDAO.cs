using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasayaNaturistCenter.Model.DAO
{
    public class ProductDAO : IProductDAO
    {
        private MasayaNaturistCenterDataBase dataBaseCotext;


        public ProductDAO(MasayaNaturistCenterDataBase parameter)
        {
            Contract.Requires(parameter != null);
            dataBaseCotext = parameter;
        }


        public void add(ProductDTO parameter)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> getAll()
        {
            return getProductDTOListOf(dataBaseCotext.Product.ToList());
        }

        private List<ProductDTO> getProductDTOListOf(List<Product> collection)
        {
            var list = new List<ProductDTO>();

            list.AddRange(collection.Select(element => getProductDTOof(element)).ToList());

            return list;
        }

        private ProductDTO getProductDTOof(Product parameter)
        {
            var element = new ProductDTO()
            {
                idProduct = parameter.idProduct,
                name = parameter.name,
                description = parameter.description,
                quantity = parameter.quantity
            };
            return element;
        }

        public List<ProductDTO> getAllOccurrencesOf(string parameter)
        {
            throw new NotImplementedException();
        }

        public void update(ProductDTO parameter)
        {
            throw new NotImplementedException();
        }
    }
}
