using MasayaNaturistCenter.Model.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        private ObservableCollection<ProductDTO> _productList;
        private ProductViewModelRecords productRecords;

        public ProductViewModel(ProductViewModelRecords parameter)
        {
            Contract.Requires(parameter != null);
            productRecords = parameter;

            productList = new ObservableCollection<ProductDTO>();
            getAll();
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
            getProductListOf(productRecords.getAll());
        }

        private void getProductListOf(List<ProductDTO> collection)
        {
            var list = new ObservableCollection<ProductDTO>();

            collection.ForEach(element => list.Add(element));

            productList = list;
        }
    }
}
