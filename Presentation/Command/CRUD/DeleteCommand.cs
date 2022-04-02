using MasayaNaturistCenter.Logic;
using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace MasayaNaturistCenter.Command
{
    public class DeleteCommand<GenericDTO> : AsyncCommandBase where GenericDTO : BaseDTO
    {
        private BaseLogic<GenericDTO> logicElement;

        public DeleteCommand( BaseLogic<GenericDTO> parameter )
        {
            Contract.Requires(parameter != null);
            logicElement = parameter;
        }

        public override async Task ExecuteAsync( object parameter )
        {
            await logicElement.delete((GenericDTO)parameter);
        }
    }
}
