using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Logic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Command
{
    public class DeleteCommand : CommandBase
    {
        private ILogic logicElement;

        public DeleteCommand( ILogic parameter )
        {
            Contract.Requires(parameter != null);
            logicElement = parameter;
        }

        public override void Execute( object parameter )
        {
            logicElement.delete((int)parameter);
        }
    }
}
