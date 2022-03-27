using MasayaNaturistCenter.Logic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Command
{
    public class SaveCommand : CommandBase
    {
        private ILogic logicElement;

        public SaveCommand(ILogic parameter)
        {
            Contract.Requires(parameter != null);
            logicElement = parameter;
        }

        public override void Execute(object parameter)
        {
            logicElement.save();
        }
    }
}
