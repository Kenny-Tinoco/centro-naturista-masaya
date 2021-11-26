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
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class Presentacion
    {
        private int idPresentacion1;
        private string nombre;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Presentacion()
        {
            this.Existencias = new HashSet<Existencia>();
        }

        public int idPresentacion { get => idPresentacion1; set => idPresentacion1 = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Existencia> Existencias { get; set; }
        
        #region Elementos del PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region Lista de productos
        private ObservableCollection<Presentacion> _registrosPresentacion;
        public ObservableCollection<Presentacion> registrosPresentacion
        {
            get
            {
                return _registrosPresentacion;
            }
            set
            {
                _registrosPresentacion = value;
                OnPropertyChanged("registrosPresentacion");
            }
        }
        public void RegistrosPresentacion_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("registrosPresentacion");
        }
        #endregion
    }
}
