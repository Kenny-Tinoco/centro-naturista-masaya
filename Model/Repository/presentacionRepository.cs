using System.Collections.Generic;
using System.Linq;

namespace CentroNaturistaMasaya.Model.Repository
{
    class presentacionRepository
    {

        #region Definicón de variables
        private CNMEntities Context = null;
        #endregion
        #region Constructor de la clase
        public presentacionRepository()
        {
            Context = new CNMEntities();
        }
        #endregion
        #region Método para obtener un producto por id
        public Presentacion get(int id)
        {
            return Context.Presentacions.Find(id);
        }
        #endregion
        #region Método para obtener una lista de todos los productos
        public List<Presentacion> getAll()
        {
            return Context.Presentacions.ToList();
        }
        #endregion        
        #region Método para obtener una lista de todos los productos que cumplen una condición (Busqueda)
        public List<Presentacion> getWhere(string cadena)
        {
            return Context
                .Presentacions
                .Where
                (
                    PD => PD.idPresentacion.ToString().Contains(cadena) ||
                    PD.Nombre.ToLower().StartsWith(cadena.ToLower())
                ).ToList();
        }
        #endregion
        #region Método para añadir un producto a la tabla
        public void addPresentacion(Presentacion objeto)
        {
            if (objeto != null)
            {
                Context.Presentacions.Add(objeto);
                Context.SaveChanges();
            }
        }
        #endregion
        #region Método para modificar un producto de la tabla
        public void updatePresentacion(Presentacion objeto)
        {
            var findProducto = get(objeto.idPresentacion);
            if (findProducto != null)
            {
                findProducto.Nombre = objeto.Nombre;
                Context.SaveChanges();
            }
        }
        #endregion
        #region Método para remover un producto de la tabla
        public void removeProducto(int id)
        {
            var objecto = Context.Presentacions.Find(id);
            if (objecto != null)
            {
                Context.Presentacions.Remove(objecto);
                Context.SaveChanges();
            }
        }
        #endregion

    }
}
