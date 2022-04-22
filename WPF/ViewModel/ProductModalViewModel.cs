using Domain.Entities;
using Domain.Logic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Input;
using WPF.Command.CRUD;
using WPF.Command.Navigation;
using WPF.MVVMEssentials.Services;

namespace WPF.ViewModel
{
    public class ProductModalViewModel : ViewModelGeneric, INotifyDataErrorInfo
    {
        private readonly ErrorsViewModel _errorsViewModel;
        public string titleBar
        {
            get
            {
                if (logic.isEditable)
                    return "Editar Producto";
                else
                    return "Agregar Producto";
            }
        }

        private ICommand _exitCommand;
        public ICommand exitCommand 
        { 
            get
            {
                return _exitCommand;
            }
        }


        private ICommand _saveCommand;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public ICommand saveCommand 
        { 
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new RelayCommand( parameter => save((bool)parameter), null);

                return _saveCommand;
            }
        }
        public async void save( bool isEdition )
        {
            await new SaveCommand<Product>(logic, canCreate).ExecuteAsync(isEdition);
            if (isEdition)
                exitCommand.Execute(1);
            else
            {
                name = logic.entity.name;
                description = logic.entity.description;
            }
        }

        public IEnumerable GetErrors( string propertyName )
        {
            return _errorsViewModel.GetErrors(propertyName);
        }

        public BaseLogic<Product> logic { get; }

        public ProductModalViewModel( BaseLogic<Product> parameter, INavigationService closeModalNavigationService )
        {
            logic = parameter;
            _exitCommand = new ExitModalCommand(closeModalNavigationService);

            _errorsViewModel = new ErrorsViewModel();
            _errorsViewModel.ErrorsChanged += ErrorsViewModel_ErrorsChanged;
        }

        private void ErrorsViewModel_ErrorsChanged( object? sender, DataErrorsChangedEventArgs e )
        {
            ErrorsChanged?.Invoke(this, e);
            OnPropertyChanged(nameof(canCreate));
        }


        public override bool canCreate
        {
            get => !HasErrors;
            set{}
        }       
        

        public bool HasErrors => _errorsViewModel.HasErrors;

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

        public string description
        {
            get
            {
                if (string.IsNullOrEmpty(logic.entity.description))
                    _errorsViewModel.AddError(nameof(description), "El nombre es nulo o vacio");

                return logic.entity.description;
            }
            set
            {
                logic.entity.description = value;
                _errorsViewModel.ClearErrors(nameof(description));

                if (string.IsNullOrEmpty(logic.entity.description))
                    _errorsViewModel.AddError(nameof(description), "Debe ingresar una descripción");
                
                OnPropertyChanged(nameof(description));
            }
        }
    }
}
