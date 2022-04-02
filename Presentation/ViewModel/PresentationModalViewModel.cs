using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Command.Crud;
using MasayaNaturistCenter.Logic;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Services;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
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
        public BaseLogic<PresentationDTO> logic { get; }

        public PresentationModalViewModel( BaseLogic<PresentationDTO> parameter, INavigationService closeModalNavigationService )
        {
            logic = parameter;
            exitCommand = new ExitModalCommand(closeModalNavigationService);
            saveCommand = new SaveCommand<PresentationDTO>(logic);
            deleteCommand = new DeleteCommand<PresentationDTO>(logic);

            logic.loadListRecordsCommand = new LoadRecordListCommand<PresentationDTO>(this);
        }

        public static PresentationModalViewModel LoadViewModel
        ( BaseLogic<PresentationDTO> parameter, INavigationService closeModalNavigationService )
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
                    _resetCommand = new RelayCommand(parametro => reset(), null);

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
                    _editCommand = new RelayCommand(parameter => edit((PresentationDTO)parameter), null);

                return _editCommand;
            }
        }
        public void edit(PresentationDTO parameter)
        {
            logic.currentDTO = parameter;
            logic.isEditable = true;
        }
    }
}
