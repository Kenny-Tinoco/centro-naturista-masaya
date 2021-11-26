using CentroNaturistaMasaya.Model;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Collections.Generic;

namespace CentroNaturistaMasaya.ViewModel
{
    public class existenciaViewModel : INotifyPropertyChanged
    {
        #region Definición de variables
        CNMEntities cnm = new CNMEntities();
        private ObservableCollection<ivProducto> _listIVExistencia;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Constructor de la clase
        public existenciaViewModel()
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
                new ObservableCollection<ivProducto>
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

        public ObservableCollection<ivProducto> listIVExistencia
        {
            get { return _listIVExistencia; }
            set
            {
                _listIVExistencia = value;
                OnPropertyChanged(nameof(listIVExistencia));
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
                            idExistencia           = E.idExistencia,
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
