using MasayaNaturistCenter.Logic;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        private ObservableCollection<ProductDTO> _productList;
        public INavigationService navigationService;
        public ILogic productLogic;
        private string _searchText;

        public ProductViewModel( ILogic productLogic, INavigationService navigationService )
        {
            Contract.Requires(navigationService != null && productLogic != null);
            this.navigationService = navigationService;
            this.productLogic = productLogic;

            productList = new ObservableCollection<ProductDTO>();
            getAll();
        }


        public string searchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
            }
        }

        public ObservableCollection<ProductDTO> productList
        {
            get { return _productList; }
            set 
            { 
                _productList = value;
                OnPropertyChanged(nameof(productList));
            }
        }

        public void getAll()
        {
            getProductListOf(productLogic.getAll());
        }

        private void getProductListOf(List<BaseDTO> collection)
        {
            var list = new ObservableCollection<ProductDTO>();

            collection.ForEach(element => list.Add((ProductDTO)element));

            productList = list;
        }
    }
}
