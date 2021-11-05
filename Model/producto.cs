using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroNaturistaMasaya.Model
{
    public class producto
    {
        private string _nombre;
        private string _descripcion;
        private int _precio;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
    }
}
