using System.Collections.Generic;
using System.Linq;

namespace CentroNaturistaMasaya.Model.Repository
{
    class existenciaRepository
    {
        private CNMEntities context = null;


        public existenciaRepository()
        {
            context = new CNMEntities();
        }


        public Existencia get(int id)
        {
            return context.Existencia.Find(id);
        }

        public List<Existencia> getAll()
        {
            return context.Existencia.ToList();
        }

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

        public void addExistencia(Existencia objeto)
        {
            if (objeto != null)
            {
                context.Existencia.Add(objeto);
                context.SaveChanges();
            }
        }

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

        public void removeExistencia(int id)
        {
            var objeto = context.Existencia.Find(id);
            if (objeto != null)
            {
                context.Existencia.Remove(objeto);
                context.SaveChanges();
            }
        }
    }
}
