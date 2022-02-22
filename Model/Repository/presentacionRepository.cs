using CentroNaturistaMasaya.Model.DAO;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows;

namespace CentroNaturistaMasaya.Model.Repository
{
    class presentacionRepository
    {
        private CNMEntities context = null;
        private Strategy strategy;

        public presentacionRepository()
        {
            context = new CNMEntities();
        }

        public presentacionRepository(Strategy strategy)
        {
            Contract.Requires(strategy != null); 
            this.strategy = strategy;
        }


        public Presentacion get(int id)
        {
            return context.Presentacion.Find(id);
        }

        public List<Presentacion> getAll()
        {
            return context.Presentacion.ToList();
        }

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
     
        public void addPresentacion(Presentacion objeto)
        {
            if (objeto != null)
            {
                context.Presentacion.Add(objeto);
                context.SaveChanges();
            }
        }
     
        public void updatePresentacion(Presentacion objeto)
        {
            var findObjeto = get(objeto.idPresentacion);
            if (findObjeto != null)
            {
                findObjeto.Nombre = objeto.Nombre;
                context.SaveChanges();
            }
        }

        public void removePresentacion(int id)
        {
            var objeto = context.Presentacion.Find(id);
            if (objeto != null)
            {
                context.Presentacion.Remove(objeto);
                context.SaveChanges();
            }
        }
    }
}
