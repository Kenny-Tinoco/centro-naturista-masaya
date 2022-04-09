using System.Windows.Data;
using System.Windows.Input;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using MasayaNaturistCenter.Services;
using MasayaNaturistCenter.Stores;
using System.Threading.Tasks;
using Domain.Logic;
using DataAccess.SqlServerDataSource;
using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Command.Crud;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel : ViewModelBase
    {

        public ICommand addCommand { get; }
        public ICommand saveCommand { get; }
        public ICommand deleteCommand { get; }
        public BaseLogic<StockView> logic { get; }

        public INavigationService navigationService;


        public StockViewModel
        ( BaseLogic<StockView> parameter, INavigationService addStockNavigationService )
        {
            Contract.Requires(parameter != null);
            logic = parameter;

            addCommand = new ParameterNavigateCommand(addStockNavigationService);
            saveCommand = new SaveCommand<StockView>(parameter);
            deleteCommand = new DeleteCommand<StockView>(parameter);

            logic.loadListRecordsCommand = new LoadRecordListCommand<StockView>(this);
        }

        public static StockViewModel LoadViewModel
        ( BaseLogic<StockView> parameter, ModalNavigationStore navigationStore, INavigationService CloseModalNavigationService)
        {
            var stockModalNavigation = new ParameterNavigationService<BaseEntity, ViewModelBase>
            (
                navigationStore, 
                ( param ) => new StockModalViewModel(CloseModalNavigationService, new DataAccess.SqlServerDataSource.Stock())
            );

            StockViewModel viewModel = new StockViewModel(parameter, stockModalNavigation);

            viewModel.logic.loadListRecordsCommand.Execute(null);

            return viewModel;
        }



        public override async Task Initialize() 
        {
            logic.getListUpdates(await logic.getAll());
            DataGridSource.Source = logic.recordList;
            dataGridSource = DataGridSource.View;
        }



        private string _searchText;

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

        private void DataGridSource_Filter(object sender, FilterEventArgs e)
        {
            StockView element = e.Item as StockView;
            if (element != null)
            {
                if((logic as StockLogic).searchLogic(element, searchText))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private bool validateSearchString(string parameter)
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
                    _dataGridSource.Source = logic.recordList;
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