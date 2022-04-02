using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DTO;

namespace Domain.Logic
{
    public class PresentationLogic : BaseLogic<PresentationDTO>
    {
        public PresentationLogic( DAOFactory parameter ) : base(parameter.presentationDAO)
        {
            currentDTO = new PresentationDTO();
        }

        public override void resetCurrentDTO()
        {
            var element = new PresentationDTO
            {
                idPresentation = 0,
                name = ""
            };
            currentDTO = element;
            isEditable = false;
        }
        public override int getId( PresentationDTO parameter )
        {
            return parameter.idPresentation;
        }
    }
}
