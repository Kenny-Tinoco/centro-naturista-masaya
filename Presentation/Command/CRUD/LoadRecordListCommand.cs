using DataAccess.Model.DTO;
using MasayaNaturistCenter.ViewModel;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace MasayaNaturistCenter.Command.Crud
{
    public class LoadRecordListCommand<Entity> : AsyncCommandBase where Entity : BaseDTO
    {
        private ViewModelBase viewModel;

        public LoadRecordListCommand( ViewModelBase parameter)
        {
            Contract.Requires(parameter != null);
            viewModel = parameter;
        }
        public override async Task ExecuteAsync( object parameter )
        {
            viewModel.IsLoading = true;
            await viewModel.Initialize();
            viewModel.IsLoading = false;
        }
    }
}
