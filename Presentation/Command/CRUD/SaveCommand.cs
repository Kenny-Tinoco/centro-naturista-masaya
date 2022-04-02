using DataAccess.Model.DTO;
using Domain.Logic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace MasayaNaturistCenter.Command
{
    public class SaveCommand<GenericDTO> : AsyncCommandBase where GenericDTO : BaseDTO 
    {
        private BaseLogic<GenericDTO> logicElement;

        public SaveCommand( BaseLogic<GenericDTO> parameter)
        {
            Contract.Requires(parameter != null);
            logicElement = parameter;
        }

        public override async Task ExecuteAsync( object parameter )
        {
            var isUpdateOperation = (bool)parameter;
            if (isUpdateOperation)
                await logicElement.edit();
            else
                await logicElement.save();
        }
    }
}
