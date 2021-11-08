using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CentroNaturistaMasaya.Model
{
    class proveedor : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (propertyName != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _idProveedor;
        private string _nombre;
        private string _direccion;
        

        public int idProveedor { get {return _idProveedor; } set { _idProveedor = value; OnPropertyChanged("idProveedor"); } }
        public string nombre { get { return _nombre; } set { _nombre = value; OnPropertyChanged("nombre"); } }
        public string direccion { get { return _direccion; } set { _direccion = value; OnPropertyChanged("direccion"); } }
    }
}
