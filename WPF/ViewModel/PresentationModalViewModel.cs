using Domain.Entities;
using Domain.Logic;
using MVVMGenericStructure.Services;
using MVVMGenericStructure.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF.Command.CRUD;
using WPF.Command.Navigation;
using WPF.ViewModel.Base;

namespace WPF.ViewModel
{
    public class PresentationModalViewModel : ViewModelGeneric<Presentation>
    {
        public string titleBar => "Presentaciones";

        private ICommand Save;

        private ICommand CloseModalCommand;

        public PresentationModalViewModel(BaseLogic<Presentation> parameter, INavigationService closeModalNavigationService) : base((PresentationLogic)parameter)
        {
            InitializeCommands(closeModalNavigationService);
        }

        private void InitializeCommands(INavigationService closeModalNavigationService)
        {
            Save = new SaveCommand<Presentation>(logic, canCreate);
            CloseModalCommand = new ExitModalCommand(closeModalNavigationService);

            SaveCommand = new RelayCommand(parameter => save((bool)parameter));
            ResetCommand = new RelayCommand(parameter => reset());
            EditCommand = new RelayCommand(parameter => edit((Presentation)parameter));
            DeleteCommand = new RelayCommand(parameter => delete((Presentation)parameter));
        }


        public static PresentationModalViewModel LoadViewModel
        (BaseLogic<Presentation> parameter, INavigationService closeModalNavigationService)
        {
            PresentationModalViewModel viewModel = new PresentationModalViewModel(parameter, closeModalNavigationService);

            viewModel.LoadCatalogueCommand.Execute(null);

            return viewModel;
        }

     

        public ICommand SaveCommand { get; set; }
        private async void save(bool parameter)
        {
            await ((SaveCommand<Presentation>)Save).ExecuteAsync(parameter);
            reset();
        }

        public ICommand ExitCommand => new RelayCommand(parameter => exit());
        private void exit()
        {
            isEditable = false;
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
        private void edit(Presentation parameter)
        {
            name = parameter.name;

            logic.entity = new Presentation
            {
                idPresentation = parameter.idPresentation,
                name = parameter.name
            };

            isEditable = true;
        }


        public ICommand DeleteCommand { get; set; }
        private async void delete(Presentation parameter)
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

    }
}
