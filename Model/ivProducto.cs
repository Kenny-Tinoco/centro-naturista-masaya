/*
Modelo de datos para la ventana de Producto
ivProducto: información de ventana Producto
*/
using System;

namespace CentroNaturistaMasaya.Model
{
    public class ivProducto
    {
        #region Definición de los atributos
        private int       _idProducto;
        private string    _nombreProducto;
        private string    _descripcionProducto;
        private string    _nombrePresentacion;
        private int       _cantidadExistencia;
        private double    _precioExistencia;
        private DateTime? _caducidadExistencia;
        private DateTime? _fechaEntradaExistencia;
        #endregion
        #region Metodos Set-Get
        public int idProducto
        {
            get => _idProducto;
            set => _idProducto = value;
        }
        public string nombreProducto
        {
            get => _nombreProducto;
            set => _nombreProducto = value; 
        }
        public string descripcionProducto
        {
            get => _descripcionProducto;
            set => _descripcionProducto = value;
        }
        public string nombrePresentacion
        {
            get => _nombrePresentacion;
            set => _nombrePresentacion = value;
        }
        public int cantidadExistencia
        {
            get => _cantidadExistencia;
            set => _cantidadExistencia = value;
        }
        public double precioExistencia
        {
            get => _precioExistencia;
            set => _precioExistencia = value;
        }
        public Nullable<System.DateTime> caducidadExistencia
        {
            get => _caducidadExistencia;
            set => _caducidadExistencia = value;
        }
        public Nullable<System.DateTime> fechaEntradaExistencia
        {
            get => _fechaEntradaExistencia;
            set => _fechaEntradaExistencia = value;
        }
        #endregion
    }
}
