namespace CentroNaturistaMasaya.Model
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class Producto : INotifyPropertyChanged
    {

        #region Definición de los atributos
        private int _idProducto;
        private string _nombre;
        private string _descripcion;
        private int _cantidad;
        #endregion
        
        #region Constructor de la clase
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Existencia = new HashSet<Existencia>();
            this.PRecetado = new HashSet<PRecetado>();
        }
        #endregion

        #region Métodos Set-Get de los atributos
        public int idProducto
        {
            get => _idProducto;
            set
            {
                _idProducto = value;
                OnPropertyChanged(nameof(idProducto));
            }
        }
        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }
        public string Descripcion
        {
            get => _descripcion;
            set
            {
                _descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }
        public int Cantidad
        {
            get => _cantidad;
            set
            {
                _cantidad = value;
                OnPropertyChanged(nameof(Cantidad));
            }
        }
        #endregion
        
        #region Referencia de entidades que tiene como foranea a producto
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Existencia> Existencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRecetado> PRecetado { get; set; }
        #endregion
        
        #region Elementos del PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        
        #region Lista de productos
        private ObservableCollection<Producto> _registrosProducto;
        public ObservableCollection<Producto> registrosProducto
        {
            get => _registrosProducto;
            set
            {
                _registrosProducto = value;
                OnPropertyChanged(nameof(registrosProducto));
            }
        }
        public void RegistrosProducto_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(registrosProducto));
        }
        #endregion

        #region Lista de nombre de los productos
        private ObservableCollection<String> _nombresProducto;
        public ObservableCollection<String> nombresProducto
        {
            get => _nombresProducto;
            set
            {
                _nombresProducto = value;
                OnPropertyChanged(nameof(nombresProducto));
            }
        }
        public void NombresProducto_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(nombresProducto));
        }
        #endregion
    }
}
