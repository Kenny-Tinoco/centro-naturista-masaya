using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class ProductDAOSQL : BaseDAOSQL, ProductDAO
    {
        public ProductDAOSQL(MasayaNaturistCenterDataBase parameter) : base(parameter)
        {
            entity = parameter.Product;
        }

        public override List<BaseDTO> getAll()
        {
            return getProductDTOListOf(dataBaseContext.Product.ToList());
        }

        public List<ProductDTO> getAllOccurrencesOf( string parameter )
        {
            throw new NotImplementedException();
        }

        private List<BaseDTO> getProductDTOListOf(List<Product> collection)
        {
            var list = new List<BaseDTO>();

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
    }
}
