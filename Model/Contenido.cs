//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentroNaturistaMasaya.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contenido
    {
        public int idContenidoS { get; set; }
        public int idSuministro { get; set; }
        public int idExistencia { get; set; }
        public int Cantidad { get; set; }
        public double PrecioC { get; set; }
        public double subTotal { get; set; }
    
        public virtual Existencia Existencia { get; set; }
        public virtual Suministro Suministro { get; set; }
    }
}