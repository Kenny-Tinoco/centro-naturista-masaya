using DataAccess.SqlServerDataSource;
using Domain.Logic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace MasayaNaturistCenter.Command
{
    public class DeleteCommand<Entity> : AsyncCommandBase where Entity : BaseEntity
    {
        private BaseLogic<Entity> logicElement;

        public DeleteCommand( BaseLogic<Entity> parameter )
        {
            Contract.Requires(parameter != null);
            logicElement = parameter;
        }

        public override async Task ExecuteAsync( object parameter )
        {
            //await logicElement.delete((Entity)parameter);
        }
    }
}
