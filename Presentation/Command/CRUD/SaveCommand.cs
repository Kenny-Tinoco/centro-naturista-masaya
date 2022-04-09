using DataAccess.SqlServerDataSource;
using Domain.Logic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace MasayaNaturistCenter.Command
{
    public class SaveCommand<Entity> : AsyncCommandBase where Entity : BaseEntity
    {
        private BaseLogic<Entity> logicElement;

        public SaveCommand( BaseLogic<Entity> parameter)
        {
            Contract.Requires(parameter != null);
            logicElement = parameter;
        }

        public override async Task ExecuteAsync( object parameter )
        {
            var isUpdateOperation = (bool)parameter;
            //if (isUpdateOperation)
            //    await logicElement.edit();
            //else
            //    await logicElement.save();
        }
    }
}
