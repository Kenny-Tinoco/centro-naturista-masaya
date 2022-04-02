using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DTO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Domain.Logic
{
    public class BaseLogic<GenericDTO> : INotifyPropertyChanged 
        where GenericDTO : BaseDTO
    {
        private GenericDTO _currentDTO;
        public GenericDTO currentDTO
        { 
            get
            {
                return _currentDTO;
            }
            set
            {
                _currentDTO = value;
                OnPropertyChanged(nameof(currentDTO));
            }
        }
        public bool isEditable
        {
            get
            {
                return _isEditable;
            }
            set
            {
                _isEditable = value;
                OnPropertyChanged(nameof(isEditable));
            }
        } 

        private BaseDAO<GenericDTO, object> _entity;
        private bool _isEditable;

        public event PropertyChangedEventHandler PropertyChanged;

        public BaseLogic( BaseDAO<GenericDTO, object> parameter )
        {
            _entity = parameter;
        }

        public async Task save()
        {
            await _entity.create(currentDTO);
            resetCurrentDTO();
            await updateRecordList();
        }

        private async Task updateRecordList()
        {
            getListUpdates(await getAll());
        }

        public async Task edit()
        {
            await _entity.update(currentDTO);
            isEditable = false;
            resetCurrentDTO();
            await updateRecordList();
        }
        public async Task delete( GenericDTO parameter )
        {
            await _entity.deleteById(getId(parameter));
            await updateRecordList();
        }

        public virtual int getId( GenericDTO parameter )
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GenericDTO>> getAll()
        {
            return await _entity.getAll();
        }

        public virtual void resetCurrentDTO()
        {
            throw new NotImplementedException();
        }

        protected void OnPropertyChanged( string propertyName )
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void getListUpdates( IEnumerable<GenericDTO> list)
        {
            recordList.Clear();

            var auxiliaryList = new ObservableCollection<GenericDTO>();
            list.ToList().ForEach(element => auxiliaryList.Add(element));

            recordList = auxiliaryList;
        }
        
        private ObservableCollection<GenericDTO> _recordList; 
        public ObservableCollection<GenericDTO> recordList
        {
            get
            {
                if (_recordList == null)
                    _recordList = new ObservableCollection<GenericDTO>();
                return _recordList;
            }
            set
            {
                _recordList = value;
                OnPropertyChanged(nameof(recordList));
            }
        }
        public ICommand loadListRecordsCommand { get; set; }
    }
}
