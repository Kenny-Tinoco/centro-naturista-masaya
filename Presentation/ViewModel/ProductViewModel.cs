using MasayaNaturistCenter.Command.Crud;
using MasayaNaturistCenter.Logic;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MasayaNaturistCenter.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        private ObservableCollection<ProductDTO> _recordsList;
        public INavigationService navigationService;
        public BaseLogic<ProductDTO> logic;
        private string _searchText;

        public ProductViewModel( BaseLogic<ProductDTO> parameter, INavigationService navigationService )
        {
            Contract.Requires(navigationService != null && parameter != null);
            this.navigationService = navigationService;
            logic = parameter;

            recordsList = new ObservableCollection<ProductDTO>();
            logic.loadListRecordsCommand = new LoadRecordListCommand<ProductDTO>(this);
        }


        public static ProductViewModel LoadViewModel
        ( BaseLogic<ProductDTO> parameter, INavigationService navigationService )
        {
            ProductViewModel viewModel = new ProductViewModel(parameter, navigationService);

            viewModel.logic.loadListRecordsCommand.Execute(null);

            return viewModel;
        }


        public ObservableCollection<ProductDTO> recordsList
        {
            get { return _recordsList; }
            set 
            { 
                _recordsList = value;
                OnPropertyChanged(nameof(recordsList));
            }
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
                search();
            }
        }

        public override async Task Initialize()
        {
            getListUpdates(await logic.getAll());
            DataGridSource.Source = recordsList;
            dataGridSource = DataGridSource.View;
        }

        private void getListUpdates( IEnumerable<ProductDTO> list )
        {
            recordsList.Clear();

            var auxiliaryList = new ObservableCollection<ProductDTO>();
            list.ToList().ForEach(element => auxiliaryList.Add(element));

            recordsList = auxiliaryList;
        }

        public void search()
        {
            if (validateSearchString(searchText))
            {
                DataGridSource.Filter += new FilterEventHandler(DataGridSource_Filter);
            }
            else if (searchText.Equals(""))
            {
                DataGridSource.Filter += null;
            }
        }

        private void DataGridSource_Filter( object sender, FilterEventArgs e )
        {
            var element = e.Item as ProductDTO;
            if (element != null)
            {
                if ((logic as ProductLogic).searchLogic(element, searchText))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private bool validateSearchString( string parameter )
        {
            Contract.Requires(parameter != null);
            bool ok = true;

            if (parameter.Trim().Equals("Búscar") || parameter.Trim().Equals(""))
            {
                ok = false;
            }

            return ok;
        }


        private ICollectionView _dataGridSourceView;
        public ICollectionView dataGridSource
        {
            get
            {
                return _dataGridSourceView;
            }
            set
            {
                _dataGridSourceView = value;
                OnPropertyChanged(nameof(dataGridSource));
            }
        }

        private CollectionViewSource _dataGridSource;
        private CollectionViewSource DataGridSource
        {
            get
            {
                if (_dataGridSource == null)
                {
                    _dataGridSource = new CollectionViewSource();
                    _dataGridSource.Source = recordsList;
                }
                return _dataGridSource;
            }
            set
            {
                _dataGridSource = value;
            }
        }
    }
}
