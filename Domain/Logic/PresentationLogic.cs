using DataAccess.DAO.DAOInterfaces;
using DataAccess.Entities;

namespace Domain.Logic
{
    public class PresentationLogic : BaseLogic<Presentation>
    {
        public PresentationLogic( DAOFactory parameter ) : base(parameter.presentationDAO)
        {
            currentDTO = new Presentation();
        }

        public override void resetCurrentDTO()
        {
            var element = new Presentation
            {
                idPresentation = 0,
                name = ""
            };
            currentDTO = element;
            isEditable = false;
        }
        public override int getId(Presentation parameter)
        {
            return parameter.idPresentation;
        }
    }
}
