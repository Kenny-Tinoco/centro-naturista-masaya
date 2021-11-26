using System.Collections.Generic;
using System.Linq;

namespace CentroNaturistaMasaya.Model.Repository
{
    class existenciaRepository
    {

        #region Definicón de variables
        private CNMEntities existenciaContext = null;
        #endregion
        #region Constructor de la clase
        public existenciaRepository()
        {
            existenciaContext = new CNMEntities();
        }
        #endregion
        #region Método para obtener una existencia por id
        public Existencia get(int id)
        {
            return existenciaContext.Existencias.Find(id);
        }
        #endregion
        #region Método para obtener una lista de todas las existencias de productos
        public List<Existencia> getAll()
        {
            return existenciaContext.Existencias.ToList();
        }
        #endregion        
        #region Método para obtener una lista de todas las existencias que cumplen una condición (Busqueda)
        public List<Existencia> getWhere(string cadena)
        {
            return existenciaContext
                .Existencias
                .Where
                (
                    PD => PD.idExistencia.ToString().Contains(cadena) 
                    //|| PD.Nombre.ToLower().StartsWith(cadena.ToLower())
                ).ToList();
        }
        #endregion
        #region Método para añadir un producto a la tabla
        public void addExistencia(Existencia existencia)
        {
            if (existencia != null)
            {
                existenciaContext.Existencias.Add(existencia);
                existenciaContext.SaveChanges();
            }
        }
        #endregion
        #region Método para modificar un producto de la tabla
        public void updateExistencia(Existencia existencia)
        {
            var findExistencia = get(existencia.idExistencia);
            if (findExistencia != null)
            {
                findExistencia.idProducto = existencia.idProducto;
                findExistencia.idPresentacion = existencia.idPresentacion;
                findExistencia.Cantidad = existencia.Cantidad;
                findExistencia.Precio = existencia.Precio;
                findExistencia.fechaEntrada = existencia.fechaEntrada;
                findExistencia.Caducidad = existencia.Caducidad;
                existenciaContext.SaveChanges();
            }
        }
        #endregion
        #region Método para remover una existencia de la tabla
        public void removeExistencia(int id)
        {
            var objectExistencia = existenciaContext.Existencias.Find(id);
            if (objectExistencia != null)
            {
                existenciaContext.Existencias.Remove(objectExistencia);
                existenciaContext.SaveChanges();
            }
        }
        #endregion

    }
}
