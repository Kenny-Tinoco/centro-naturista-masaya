using CentroNaturistaMasaya.Model;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace CentroNaturistaMasaya.ViewModel
{
    public class productoViewModel : INotifyPropertyChanged
    {
        #region Definición de variables
        CNMEntities cnm = new CNMEntities();
        private ObservableCollection<ivProducto> _listIVProducto;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Constructor de la clase
        public productoViewModel()
        {
            mostrarDatos();
        }
        #endregion

        public void mostrarDatos()
        {
            listIVProducto = getData();
        }

        public ObservableCollection<ivProducto> listIVProducto
        {
            get { return _listIVProducto; }
            set
            {
                _listIVProducto = value;
                OnPropertyChanged(nameof(listIVProducto));
            }
        }
        private ObservableCollection<ivProducto> getData()
        {
            var Existencias = cnm.Existencias;
            var Productos = cnm.Productoes;
            var Presentaciones = cnm.Presentacions;

            var query = from E in Existencias
                        join PD in Productos
                            on E.idProducto equals PD.idProducto
                        join PS in Presentaciones
                            on E.idPresentacion equals PS.idPresentacion
                        select new ivProducto()
                        {
                            idProducto             = PD.idProducto,
                            nombreProducto         = PD.Nombre,
                            descripcionProducto    = PD.Descripcion,
                            nombrePresentacion     = PS.Nombre,
                            cantidadExistencia     = E.Cantidad,
                            precioExistencia       = E.Precio,
                            caducidadExistencia    = E.Caducidad,
                            fechaEntradaExistencia = E.fechaEntrada
                        };
            return new ObservableCollection<ivProducto>(query);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
