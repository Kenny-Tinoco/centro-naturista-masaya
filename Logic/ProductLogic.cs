using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Logic
{
    public class ProductLogic : ILogic
    {
        public ProductDTO currentStock { get; set; }
        private DAOFactory daoFactory;
        private ProductDAO entity;


        public ProductLogic( DAOFactory parameter )
        {
            Contract.Requires(parameter != null);
            daoFactory = parameter;
            entity = daoFactory.productDAO;
        }


        public void delete( int parameter )
        {
            throw new NotImplementedException();
        }

        public List<BaseDTO> getAll()
        {
            return entity.getAll(); 
        }

        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
