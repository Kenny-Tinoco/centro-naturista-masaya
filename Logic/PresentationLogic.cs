using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
using System;
using System.Collections.Generic;

namespace MasayaNaturistCenter.Logic
{
    public class PresentationLogic : ILogic
    {
        public PresentationDTO currentPresentation { get; set; }
        private DAOFactory daoFactory;
        private PresentationDAO entity;

        public PresentationLogic( DAOFactory parameter )
        {
            daoFactory = parameter;
            entity = parameter.presentationDAO;
            currentPresentation = new PresentationDTO();
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
            entity.create(currentPresentation);
            currentPresentation = new PresentationDTO();
        }
    }
}
