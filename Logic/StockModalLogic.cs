using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using System;
using System.Collections.Generic;

namespace MasayaNaturistCenter.Logic
{
    public class StockModalLogic : ILogic
    {
        public StockDTO currentStock { get; set; }
        private DAOFactory daoFactory;
        private ProductDAO productDAO;
        private PresentationDAO presentationDAO;

        public StockModalLogic( DAOFactory parameter )
        {
            daoFactory = parameter;
            productDAO = daoFactory.productDAO;
            presentationDAO = daoFactory.presentationDAO;
        }

        public void delete( int parameter )
        {
            throw new NotImplementedException();
        }

        public List<BaseDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
