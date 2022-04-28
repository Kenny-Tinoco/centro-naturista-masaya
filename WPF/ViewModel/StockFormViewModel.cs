using Domain.Entities;
using Domain.Logic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Input;
using MVVMGenericStructure.Commands;
using MVVMGenericStructure.Services;

namespace WPF.ViewModel
{
    public class StockFormViewModel : ViewModelGeneric, INotifyDataErrorInfo
    {
        private readonly ErrorsViewModel _errorsViewModel;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public Stock stock { get; set; }
        public Stock productoRecord { get; set; }

        public string title { get; }

        public ICommand backCommand { get; }
        public ICommand saveCommand { get; }
        public ICommand searchCommand { get; }
        public BaseLogic<Stock> stockLogic;
        public BaseLogic<Product> productLogic;
        public BaseLogic<Presentation> presentationLogic;

        public StockFormViewModel( LogicFactory logic, INavigationService backNavigation, INavigationService modalNavigation )
        {
            title = "Agregar una nueva existencia";
            backCommand = new NavigateCommand(backNavigation);
            searchCommand = new NavigateCommand(modalNavigation);
            
            stockLogic = logic.stockModalLogic;
            productLogic = logic.productLogic;
            presentationLogic = logic.presentationModalLogic;
        }



        public double price
        {
            get
            {

                return stockLogic.entity.price;
            }
            set
            {
                stockLogic.entity.price = value;
                _errorsViewModel.ClearErrors(nameof(price));

                if (stockLogic.entity.price < 0)
                    _errorsViewModel.AddError(nameof(price), "Ingrese un precio positivo");

                OnPropertyChanged(nameof(price));
            }
        }

        public int quantity
        {
            get
            {

                return stockLogic.entity.quantity;
            }
            set
            {
                stockLogic.entity.quantity = value;
                OnPropertyChanged(nameof(quantity));
            }
        }

        public bool HasErrors => throw new NotImplementedException();

        public IEnumerable GetErrors( string? propertyName )
        {
            throw new NotImplementedException();
        }
    }
}
