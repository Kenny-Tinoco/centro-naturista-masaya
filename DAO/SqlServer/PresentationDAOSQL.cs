using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DataSource;
using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class PresentationDAOSQL : BaseDAOSQL<Presentation>, PresentationDAO
    {
        public PresentationDAOSQL( MasayaNaturistCenterDataBase dataBaseContext ) : base(dataBaseContext)
        {
            entity = dataBaseContext.Presentation;
        }

        public override Presentation converter( BaseDTO element )
        {
            var specificDTO = (PresentationDTO) element;
            return new Presentation 
            { 
                name = specificDTO.name 
            };
        }

        public override BaseDTO convertToDTO( Presentation parameter )
        {
            var element = new PresentationDTO
            {
                idPresentation = parameter.idPresentation,
                name = parameter.name
            };

            return element;
        }
    }
}
