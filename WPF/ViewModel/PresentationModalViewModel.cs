using Domain.Logic;
using WPF.Command;
using WPF.Command.Crud;
using WPF.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.ViewModel
{
    public class PresentationModalViewModel : ViewModelBase
    {

        public string titleBar
        {
            get
            {
                return "Presentaciones";
            }
        }

        public ICommand exitCommand { get; }
        public ICommand saveCommand { get; }
        public ICommand deleteCommand { get; }
        public BaseLogic<DataAccess.SqlServerDataSource.Presentation> logic { get; }

        public PresentationModalViewModel( BaseLogic<DataAccess.SqlServerDataSource.Presentation> parameter, INavigationService closeModalNavigationService )
        {
            logic = parameter;
            exitCommand = new ExitModalCommand(closeModalNavigationService);
            saveCommand = new SaveCommand<DataAccess.SqlServerDataSource.Presentation>(logic);
            deleteCommand = new DeleteCommand<DataAccess.SqlServerDataSource.Presentation>(logic);

            logic.loadListRecordsCommand = new LoadRecordListCommand<DataAccess.SqlServerDataSource.Presentation>(this);
        }

        public static PresentationModalViewModel LoadViewModel
        ( BaseLogic<DataAccess.SqlServerDataSource.Presentation> parameter, INavigationService closeModalNavigationService )
        {
            PresentationModalViewModel viewModel = new PresentationModalViewModel(parameter, closeModalNavigationService);

            viewModel.logic.loadListRecordsCommand.Execute(null);

            return viewModel;
        }



        public override async Task Initialize()
        {
            logic.getListUpdates(await logic.getAll());
        }


        private ICommand _resetCommand;
        public ICommand resetCommand
        {
            get
            {
                if (_resetCommand == null)
                    _resetCommand = new RelayCommand(parameter => reset(), null);

                return _resetCommand;
            }
        }
        public void reset()
        {
            logic.resetCurrentDTO();
        }


        private ICommand _editCommand;
        public ICommand editCommand
        {
            get
            {
                if (_editCommand == null)
                    _editCommand = new RelayCommand(parameter => edit((DataAccess.SqlServerDataSource.Presentation)parameter), null);

                return _editCommand;
            }
        }
        public void edit( DataAccess.SqlServerDataSource.Presentation parameter)
        {
            logic.currentDTO = parameter;
            logic.isEditable = true;
        }
    }
}
