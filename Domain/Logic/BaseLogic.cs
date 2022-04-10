using DataAccess.DAO.DAOInterfaces;
using DataAccess.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Domain.Logic
{
    public class BaseLogic<Entity> : INotifyPropertyChanged 
        where Entity : BaseEntity
    {
        private Entity _currentDTO;
        public Entity currentDTO
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

        private BaseDAO<Entity, object> _entity;
        private bool _isEditable;

        public event PropertyChangedEventHandler PropertyChanged;

        public BaseLogic(BaseDAO<Entity, object> parameter)
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
            resetCurrentDTO();
            await updateRecordList();
            isEditable = false;
        }
        public async Task delete(Entity parameter)
        {
            await _entity.deleteById(getId(parameter));
            await updateRecordList();
        }

        public virtual int getId(Entity parameter)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Entity>> getAll()
        {
            return await _entity.getAll();
        }

        public virtual void resetCurrentDTO()
        {
            throw new NotImplementedException();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void getListUpdates(IEnumerable<Entity> list)
        {
            recordList.Clear();

            var auxiliaryList = new ObservableCollection<Entity>();
            list.ToList().ForEach(element => auxiliaryList.Add(element));

            recordList = auxiliaryList;
        }

        private ObservableCollection<Entity> _recordList;
        public ObservableCollection<Entity> recordList
        {
            get
            {
                if (_recordList == null)
                    _recordList = new ObservableCollection<Entity>();
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
