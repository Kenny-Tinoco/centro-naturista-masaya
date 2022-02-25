using MasayaNaturistCenter.Model;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Collections.Generic;

namespace MasayaNaturistCenter.ViewModel
{
    public class existenciaProductoViewModel : INotifyPropertyChanged
    {
        #region Definición de variables
        CNMEntities cnm = new CNMEntities();
        private ObservableCollection<existenciaProducto> _listIVExistencia;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Constructor de la clase
        public existenciaProductoViewModel()
        {
            mostrarDatos();
        }
        #endregion

        public void mostrarDatos()
        {
            listIVExistencia = getData();
        }
        public void buscarRegistro(string valor = null)
        {
            listIVExistencia = 
                new ObservableCollection<existenciaProducto>
                (
                    listIVExistencia
                        .Where
                        (
                            E => E.idExistencia.ToString().Contains(valor) || 
                            E.nombreProducto.ToLower().StartsWith(valor.ToLower()) ||
                            E.nombrePresentacion.ToLower().StartsWith(valor.ToLower())
                        )
                );
        }

        public ObservableCollection<existenciaProducto> listIVExistencia
        {
            get { return _listIVExistencia; }
            set
            {
                _listIVExistencia = value;
                OnPropertyChanged(nameof(listIVExistencia));
            }
        }
        private ObservableCollection<existenciaProducto> getData()
        {
            var Existencias = cnm.Existencia;
            var Productos = cnm.Producto;
            var Presentaciones = cnm.Presentacion;

            var query = from E in Existencias
                        join PD in Productos
                            on E.idProducto equals PD.idProducto
                        join PS in Presentaciones
                            on E.idPresentacion equals PS.idPresentacion
                        select new existenciaProducto()
                        {
                            idExistencia           = E.idExistencia,
                            nombreProducto         = PD.Nombre,
                            descripcionProducto    = PD.Descripcion,
                            nombrePresentacion     = PS.Nombre,
                            cantidadExistencia     = E.Cantidad,
                            precioExistencia       = E.Precio,
                            caducidadExistencia    = E.Caducidad,
                            fechaEntradaExistencia = E.fechaEntrada
                        };
            return new ObservableCollection<existenciaProducto>(query);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
