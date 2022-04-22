using Domain.DAO;
using Domain.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Domain.Logic
{
    public class BaseLogic<Entity> : INotifyPropertyChanged where Entity : BaseEntity
    {
        private BaseDAO<Entity, object> _dao;

        public BaseLogic(BaseDAO<Entity, object> parameter)
        {
            _dao = parameter;
        }


        public async Task save()
        {
            await _dao.create(entity);
            resetEntity();
            await updateCatalogue();
        }

        public async Task edit()
        {
            await _dao.update(entity);
            resetEntity();
            await updateCatalogue();
        }
       
        public async Task delete(Entity parameter)
        {
            await _dao.deleteById(getId(parameter));
            await updateCatalogue();
        }

        public virtual int getId(Entity parameter)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Entity>> getAll()
        {
            return await _dao.getAll();
        }



        private async Task updateCatalogue()
        {
            RefreshCatalogue(await getAll());
        }

        public virtual void resetEntity()
        {
            throw new NotImplementedException();
        }

        public void RefreshCatalogue(IEnumerable<Entity> list)
        {
            catalogue.Clear();

            var auxiliaryList = new ObservableCollection<Entity>();
            list.ToList().ForEach(element => auxiliaryList.Add(element));

            catalogue = auxiliaryList;
        }


        public ICommand LoadCatalogueCommand { get; set; } = null!;

        private ObservableCollection<Entity> _catalogue = null!;
        public ObservableCollection<Entity> catalogue
        {
            get
            {
                if (_catalogue == null)
                    _catalogue = new ObservableCollection<Entity>();
                return _catalogue;
            }
            set
            {
                _catalogue = value;
                OnPropertyChanged(nameof(catalogue));
            }
        }

        private bool _isEditable;
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

        private Entity _entity = null!;
        public Entity entity
        {
            get
            {
                return _entity;
            }
            set
            {
                _entity = value;
                OnPropertyChanged(nameof(entity));
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
