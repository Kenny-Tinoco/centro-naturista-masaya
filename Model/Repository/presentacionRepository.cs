using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CentroNaturistaMasaya.Model.Repository
{
    class presentacionRepository
    {

        #region Definicón de variables
        private CNMEntities context = null;
        #endregion

        #region Constructor de la clase
        public presentacionRepository()
        {
            context = new CNMEntities();
        }
        #endregion

        #region Método para obtener un registro por id
        public Presentacion get(int id)
        {
            return context.Presentacion.Find(id);
        }
        #endregion

        #region Método para obtener una lista de todos los registros
        public List<Presentacion> getAll()
        {
            return context.Presentacion.ToList();
        }
        #endregion

        #region Método para obtener una lista de todos los registros que cumplen una condición (Busqueda)
        public List<Presentacion> getWhere(string cadena)
        {
            return context
                .Presentacion
                .Where
                (
                    objeto =>
                        objeto.idPresentacion.ToString().Contains(cadena) ||
                        objeto.Nombre.ToLower().StartsWith(cadena.ToLower())
                ).ToList();
        }
        #endregion

        #region Método para añadir un registro a la tabla
        public void addPresentacion(Presentacion objeto)
        {
            if (objeto != null)
            {
                context.Presentacion.Add(objeto);
                context.SaveChanges();
            }
        }
        #endregion

        #region Método para modificar un registro de la tabla
        public void updatePresentacion(Presentacion objeto)
        {
            var findObjeto = get(objeto.idPresentacion);
            if (findObjeto != null)
            {
                findObjeto.Nombre = objeto.Nombre;
                context.SaveChanges();
            }
        }
        #endregion

        #region Método para remover un registro de la tabla
        public void removePresentacion(int id)
        {
            var objeto = context.Presentacion.Find(id);
            if (objeto != null)
            {
                context.Presentacion.Remove(objeto);
                context.SaveChanges();
            }
        }
        #endregion

    }
}
