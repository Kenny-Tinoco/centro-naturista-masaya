using System.Collections.Generic;
using System.Linq;

namespace CentroNaturistaMasaya.Model.Repository
{
    class existenciaRepository
    {

        #region Definicón de variables
        private CNMEntities context = null;
        #endregion

        #region Constructor de la clase
        public existenciaRepository()
        {
            context = new CNMEntities();
        }
        #endregion

        #region Método para obtener una existencia por id
        public Existencia get(int id)
        {
            return context.Existencia.Find(id);
        }
        #endregion

        #region Método para obtener una lista de todas las existencias
        public List<Existencia> getAll()
        {
            return context.Existencia.ToList();
        }
        #endregion

        #region Método para obtener una lista de todas las existencias que cumplen una condición (Busqueda)
        public List<Existencia> getWhere(string cadena)
        {
            return context
                .Existencia
                .Where
                (
                    objeto =>
                    objeto.idExistencia.ToString().Contains(cadena) ||
                    objeto.Producto.Nombre.ToLower().StartsWith(cadena.ToLower()) ||
                    objeto.Presentacion.Nombre.ToLower().StartsWith(cadena.ToLower())
                ).ToList();
        }
        #endregion

        #region Método para añadir una existencia a la tabla
        public void addExistencia(Existencia objeto)
        {
            if (objeto != null)
            {
                context.Existencia.Add(objeto);
                context.SaveChanges();
            }
        }
        #endregion

        #region Método para modificar una existencia de la tabla
        public void updateExistencia(Existencia objeto)
        {
            var findObjeto = get(objeto.idExistencia);
            if (findObjeto != null)
            {
                findObjeto.idPresentacion = objeto.idPresentacion;
                findObjeto.idProducto = objeto.idProducto;
                findObjeto.Precio = objeto.Precio;
                findObjeto.Cantidad = objeto.Cantidad;
                findObjeto.Caducidad = objeto.Caducidad;
                findObjeto.fechaEntrada = objeto.fechaEntrada;
                findObjeto.Producto = objeto.Producto;
                findObjeto.Presentacion = objeto.Presentacion;
                context.SaveChanges();
            }
        }
        #endregion

        #region Método para remover una existencia de la tabla
        public void removeExistencia(int id)
        {
            var objeto = context.Existencia.Find(id);
            if (objeto != null)
            {
                context.Existencia.Remove(objeto);
                context.SaveChanges();
            }
        }
        #endregion


    }
}
