using System.Collections.Generic;
using System.Linq;

namespace CentroNaturistaMasaya.Model.Repository
{
    class productoRepository
    {

        #region Definicón de variables
        private CNMEntities context = null;
        #endregion

        #region Constructor de la clase
        public productoRepository()
        {
            context = new CNMEntities();
        }
        #endregion

        #region Método para obtener un producto por id
        public Producto get(int id)
        {
            return context.Producto.Find(id);
        }
        #endregion

        #region Método para obtener una lista de todos los productos
        public List<Producto> getAll()
        {
            return context.Producto.ToList();
        }
        #endregion

        #region Método para obtener una lista de los nombre de los registros
        #endregion

        #region Método para obtener una lista de todos los productos que cumplen una condición (Busqueda)
        public List<Producto> getWhere(string cadena)
        {
            return context
                .Producto
                .Where
                (
                    objeto => 
                    objeto.idProducto.ToString().Contains(cadena) ||
                    objeto.Nombre.ToLower().StartsWith(cadena.ToLower())
                ).ToList();
        }
        #endregion

        #region Método para añadir un producto a la tabla
        public void addProducto(Producto objeto)
        {
            if (objeto != null)
            {
                context.Producto.Add(objeto);
                context.SaveChanges();
            }
        }
        #endregion

        #region Método para modificar un producto de la tabla
        public void updateProducto(Producto objeto)
        {
            var findObjeto = get(objeto.idProducto);
            if (findObjeto != null)
            {
                findObjeto.Nombre = objeto.Nombre;
                findObjeto.Descripcion = objeto.Descripcion;
                findObjeto.Cantidad = objeto.Cantidad;
                context.SaveChanges();
            }
        }
        #endregion

        #region Método para remover un producto de la tabla
        public void removeProducto(int id)
        {
            var objeto = context.Producto.Find(id);
            if (objeto != null)
            {
                context.Producto.Remove(objeto);
                context.SaveChanges();
            }
        }
        #endregion

    }
}
