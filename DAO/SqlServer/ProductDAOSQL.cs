using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Model.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class ProductDAOSQL : BaseDAOSQL<Product>, ProductDAO
    {
        public ProductDAOSQL(MasayaNaturistCenterDataBase parameter) : base(parameter)
        {
            entity = parameter.Product;
        }

        public override BaseDTO convertToDTO( Product parameter )
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

        public override Product converter( BaseDTO element )
        {
            var specificDTO = (ProductDTO)element;
            return new Product()
            {
                idProduct = specificDTO.idProduct,
                name = specificDTO.name,
                description = specificDTO.description,
                quantity = specificDTO.quantity
            };
        }
    }
}
