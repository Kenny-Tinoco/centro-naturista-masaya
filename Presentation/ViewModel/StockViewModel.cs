using System.Windows.Data;
using System.Windows.Input;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using MasayaNaturistCenter.Services;
using MasayaNaturistCenter.Stores;
using MasayaNaturistCenter.Command;
using System.Threading.Tasks;
using MasayaNaturistCenter.Command.Crud;
using Domain.Logic;
using DataAccess.Model.DTO;

namespace MasayaNaturistCenter.ViewModel
{
    public class StockViewModel : ViewModelBase
    {

        public ICommand addCommand { get; }
        public ICommand saveCommand { get; }
        public ICommand deleteCommand { get; }
        public BaseLogic<StockViewDTO> logic { get; }

        public INavigationService navigationService;


        public StockViewModel
        ( BaseLogic<StockViewDTO> parameter, INavigationService addStockNavigationService )
        {
            Contract.Requires(parameter != null);
            logic = parameter;

            addCommand = new ParameterNavigateCommand(addStockNavigationService);
            saveCommand = new SaveCommand<StockViewDTO>(parameter);
            deleteCommand = new DeleteCommand<StockViewDTO>(parameter);

            logic.loadListRecordsCommand = new LoadRecordListCommand<StockViewDTO>(this);
        }

        public static StockViewModel LoadViewModel
        ( BaseLogic<StockViewDTO> parameter, ModalNavigationStore navigationStore, INavigationService CloseModalNavigationService)
        {
            var stockModalNavigation = new ParameterNavigationService<BaseDTO, ViewModelBase>
            (
                navigationStore, 
                ( param ) => new StockModalViewModel(CloseModalNavigationService, new StockDTO())
            );

            StockViewModel viewModel = new StockViewModel(parameter,stockModalNavigation);

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
            StockViewDTO element = e.Item as StockViewDTO;
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