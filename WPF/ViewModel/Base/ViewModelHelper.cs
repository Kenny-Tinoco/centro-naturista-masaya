using Domain.Entities;
using Domain.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.ViewModel
{
    public class ViewModelHelper<Entity> : INotifyPropertyChanged where Entity : BaseEntity
    {
        private BaseLogic<Entity> logic;
        public ViewModelHelper()
        {

        }
        public ViewModelHelper( BaseLogic<Entity> logic )
        {
            this.logic = logic;
        }

        private async Task updateCatalogue()
        {
            RefreshCatalogue(await logic.getAll());
        }


        public void RefreshCatalogue( IEnumerable<Entity> list )
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

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged( string propertyName )
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
