using DataAccess.Entities;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using WPF.MVVMEssentials.Commands;
using WPF.MVVMEssentials.ViewModels;
using WPF.ViewModel;

namespace WPF.Command.Crud
{
    public class LoadRecordListCommand<Entity> : AsyncCommandBase where Entity : BaseEntity
    {
        private ViewModelGeneric viewModel;

        public LoadRecordListCommand( ViewModelBase parameter)
        {
            Contract.Requires(parameter != null);
            viewModel = (ViewModelGeneric)parameter;
        }
        public override async Task ExecuteAsync( object parameter )
        {
            viewModel.IsLoading = true;
            await viewModel.Initialize();
            viewModel.IsLoading = false;
        }
    }
}
