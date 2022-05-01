using Domain.Entities;
using Domain.Logic;
using System.Windows.Input;
using WPF.Command.CRUD;
using WPF.Command.Navigation;
using MVVMGenericStructure.Services;

namespace WPF.ViewModel
{
    public class ProductModalViewModel : ViewModelGeneric<Product>
    {


        public ProductModalViewModel(BaseLogic<Product> parameter, INavigationService closeModalNavigationService) : base((ProductLogic)parameter)
        {
            exitCommand = new ExitModalCommand(closeModalNavigationService);

            _save = new SaveCommand<Product>(logic, canCreate);
            saveCommand = new RelayCommand(parameter => save((bool)parameter));
        }



        public string titleBar
        {
            get
            {
                if (isEditable)
                    return "Editar Producto";
                
                return "Agregar Producto";
            }
        }

        public ICommand exitCommand { get; }


        private ICommand _save;
        public ICommand saveCommand { get; }
        public void save( bool isEdition )
        {
            _save.Execute(isEdition);
            LoadCatalogueCommand.Execute(null);

            if (isEdition)
                exitCommand.Execute(1);
            else
            {
                name = logic.entity.name;
                description = logic.entity.description;
            }

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
