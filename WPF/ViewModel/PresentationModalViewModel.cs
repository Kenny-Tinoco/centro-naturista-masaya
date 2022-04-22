using Domain.Entities;
using Domain.Logic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF.Command.Crud;
using WPF.Command.CRUD;
using WPF.Command.Navigation;
using WPF.MVVMEssentials.Services;

namespace WPF.ViewModel
{
    public class PresentationModalViewModel : ViewModelGeneric, INotifyDataErrorInfo
    {
        private readonly ErrorsViewModel _errorsViewModel;

        public string titleBar => "Presentaciones";

        private ICommand Save;
        public PresentationLogic logic { get; }

        private ICommand CloseModalCommand;

        public PresentationModalViewModel( BaseLogic<Presentation> parameter, INavigationService closeModalNavigationService )
        {
            logic = parameter as PresentationLogic;

            _errorsViewModel = new ErrorsViewModel();
            _errorsViewModel.ErrorsChanged += ErrorsViewModel_ErrorsChanged;

            InitializeCommands(closeModalNavigationService);
        }
        private void InitializeCommands( INavigationService closeModalNavigationService )
        {
            Save = new SaveCommand<Presentation>(logic, canCreate); 
            CloseModalCommand = new ExitModalCommand(closeModalNavigationService);
            logic.LoadCatalogueCommand = new LoadRecordListCommand<Presentation>(this);

            SaveCommand = new RelayCommand(parameter => save((bool)parameter), null);
            ResetCommand = new RelayCommand(parameter => reset(), null);
            EditCommand = new RelayCommand(parameter => edit((Presentation)parameter), null);
            DeleteCommand = new RelayCommand(parameter => delete((Presentation)parameter), null);
        }


        public static PresentationModalViewModel LoadViewModel
        ( BaseLogic<Presentation> parameter, INavigationService closeModalNavigationService )
        {
            PresentationModalViewModel viewModel = new PresentationModalViewModel(parameter, closeModalNavigationService);

            viewModel.logic.LoadCatalogueCommand.Execute(null);

            return viewModel;
        }

        public override async Task Initialize()
        {
            logic.RefreshCatalogue(await logic.getAll());
        }

        public ICommand SaveCommand { get; set; }
        private async void save(bool parameter)
        {
            await (Save as SaveCommand<Presentation>).ExecuteAsync(parameter);
            reset();
        }

        public ICommand ExitCommand => new RelayCommand(parameter => exit(), null);
        private void exit()
        {
            logic.isEditable = false;
            reset();
            CloseModalCommand.Execute(null);
        }


        public ICommand ResetCommand { get; set; }
        private void reset()
        {
            logic.resetEntity();
            name = logic.entity.name;
        }


        public ICommand EditCommand { get; set; }
        private void edit( Presentation parameter )
        {
            name = parameter.name;

            logic.entity = new Presentation
            {
                idPresentation = parameter.idPresentation,
                name = parameter.name
            };

            logic.isEditable = true;
        }


        public ICommand DeleteCommand { get; set; }
        private async void delete( Presentation parameter )
        {
            var result = MessageBox
                .Show("¿Está seguro de eliminar esta presentación?", "Confirmar Eliminación", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
                await new DeleteCommand<Presentation>(logic).ExecuteAsync(parameter);
        }


        public string name
        {
            get
            {
                if (string.IsNullOrEmpty(logic.entity.name))
                    _errorsViewModel.AddError(nameof(name), "El nombre es nulo o vacio");

                return logic.entity.name;
            }
            set
            {
                logic.entity.name = value;
                _errorsViewModel.ClearErrors(nameof(name));

                if (string.IsNullOrEmpty(logic.entity.name))
                    _errorsViewModel.AddError(nameof(name), "Debe ingresar un nombre");

                OnPropertyChanged(nameof(name));
            }
        }

        public override bool canCreate
        {
            get => !HasErrors;
            set { }
        }

        public bool HasErrors => _errorsViewModel.HasErrors;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
        private void ErrorsViewModel_ErrorsChanged( object? sender, DataErrorsChangedEventArgs e )
        {
            ErrorsChanged?.Invoke(this, e);
            OnPropertyChanged(nameof(canCreate));
        }

        public IEnumerable GetErrors( string? propertyName )
        {
            return _errorsViewModel.GetErrors(propertyName);
        }
    }
}
