using Domain.Logic;
using WPF.Command.Crud;
using System.Windows.Input;
using WPF.MVVMEssentials.Services;
using WPF.Command.Navigation;
using WPF.Command.CRUD;
using System.Threading.Tasks;
using System.Windows;
using Domain.Entities;

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

        public ICommand saveCommand { get; }
        public BaseLogic<Presentation> logic { get; }
        public INavigationService closeModalNavigationService;

        public PresentationModalViewModel( BaseLogic<Presentation> parameter, INavigationService closeModalNavigationService )
        {
            logic = parameter;
            this.closeModalNavigationService = closeModalNavigationService;
            saveCommand = new SaveCommand<Presentation>(logic, this.canCreate);
            //deleteCommand = new DeleteCommand<Presentation>(logic);

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
        public void edit(in Presentation parameter )
        {
            logic.currentDTO = new Presentation
            {
                idPresentation = parameter.idPresentation,
                name = parameter.name
            }; 

            logic.isEditable = true;
        }

        private ICommand _addCommand;
        public ICommand exitCommand
        {
            get
            {
                if (_addCommand == null)
                    _addCommand = new RelayCommand(parameter => add(), null);

                return _addCommand;
            }
        }

        public void add()
        {
            logic.isEditable = false;
            logic.resetCurrentDTO(); 
            new ExitModalCommand(closeModalNavigationService).Execute(1);
        }


        private ICommand _deleteCommand;
        public ICommand deleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                    _deleteCommand = new RelayCommand(parameter => delete((Presentation)parameter), null);

                return _deleteCommand;
            }
        }

        public async void delete( Presentation parameter )
        {
            var result = MessageBox
                .Show("¿Está seguro de eliminar esta presentación?", "Confirmar Eliminación", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
                await new DeleteCommand<Presentation>(logic).ExecuteAsync(parameter);
        }
    }
}
