using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace CentroNaturistaMasaya.Model
{
    class productoRecord : Producto, INotifyPropertyChanged
    {
        private ObservableCollection<productoRecord> _productoRecords;
        public ObservableCollection<productoRecord> productoRecords
        {
            get
            {
                return _productoRecords;
            }
            set
            {
                _productoRecords = value;
                OnPropertyChanged("productoRecords");
            }
        }



        private void StudentModels_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("productoRecords");
        }
    }
}
