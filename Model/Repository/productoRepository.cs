using System.Collections.Generic;
using System.Linq;

namespace CentroNaturistaMasaya.Model.Repository
{
    class productoRepository
    {

        #region Definicón de variables
        private CNMEntities productoContext = null;
        #endregion
        #region Constructor de la clase
        public productoRepository()
        {
            productoContext = new CNMEntities();
        }
        #endregion
        #region Método para obtener un producto por id
        public Producto get(int id)
        {
            return productoContext.Productoes.Find(id);
        }
        #endregion
        #region Método para obtener una lista de todos los productos
        public List<Producto> getAll()
        {
            return productoContext.Productoes.ToList();
        }
        #endregion        
        #region Método para obtener una lista de todos los productos que cumplen una condición (Busqueda)
        public List<Producto> getWhere(string cadena)
        {
            return productoContext
                .Productoes
                .Where
                (
                    PD => PD.idProducto.ToString().Contains(cadena) ||
                    PD.Nombre.ToLower().StartsWith(cadena.ToLower())
                ).ToList();
        }
#endregion
        #region Método para añadir un producto a la tabla
        public void addProducto(Producto producto)
        {
            if (producto != null)
            {
                productoContext.Productoes.Add(producto);
                productoContext.SaveChanges();
            }
        }
        #endregion
        #region Método para modificar un producto de la tabla
        public void updateProducto(Producto producto)
        {
            var findProducto = get(producto.idProducto);
            if (findProducto != null)
            {
                findProducto.Nombre = producto.Nombre;
                findProducto.Descripcion = producto.Descripcion;
                findProducto.Cantidad = producto.Cantidad;
                productoContext.SaveChanges();
            }
        }
        #endregion
        #region Método para remover un producto de la tabla
        public void removeProducto(int id)
        {
            var objectProducto = productoContext.Productoes.Find(id);
            if (objectProducto != null)
            {
                productoContext.Productoes.Remove(objectProducto);
                productoContext.SaveChanges();
            }
        }
        #endregion

    }
}
