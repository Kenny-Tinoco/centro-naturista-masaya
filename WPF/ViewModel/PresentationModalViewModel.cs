using Domain.Logic;
using WPF.Command.Crud;
using System.Windows.Input;
using WPF.MVVMEssentials.Services;
using DataAccess.Entities;
using WPF.Command.Navigation;
using WPF.Command.CRUD;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
    public class PresentationModalViewModel : ViewModelGeneric
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
        public BaseLogic<Presentation> logic { get; }

        public PresentationModalViewModel( BaseLogic<Presentation> parameter, INavigationService closeModalNavigationService )
        {
            logic = parameter;
            exitCommand = new ExitModalCommand(closeModalNavigationService);
            saveCommand = new SaveCommand<Presentation>(logic);
            deleteCommand = new DeleteCommand<Presentation>(logic);

            logic.loadListRecordsCommand = new LoadRecordListCommand<Presentation>(this);
        }

        public static PresentationModalViewModel LoadViewModel
        ( BaseLogic<Presentation> parameter, INavigationService closeModalNavigationService )
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
                    _editCommand = new RelayCommand(parameter => edit((Presentation)parameter), null);

                return _editCommand;
            }
        }
        public void edit( Presentation parameter )
        {
            logic.currentDTO = parameter;
            logic.isEditable = true;
        }
    }
}
