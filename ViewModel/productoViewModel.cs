using CentroNaturistaMasaya.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CentroNaturistaMasaya.Model.Repository;
using System.Windows;
using System;
using System.Collections.Specialized;

namespace CentroNaturistaMasaya.ViewModel
{
    public class productoViewModel
    {

        #region Definición de los atributos
        private ICommand _saveCommand;
        private ICommand _resetCommand;
        private ICommand _editCommand;
        private ICommand _deleteCommand;

        private Producto _productoEntity = null;
        public Producto productoRecord { get; set; }
        public Producto productoSelected { get; set; }
        public CNMEntities productoEntities { get; set; }
        
        private productoRepository _repository;
        #endregion

        #region Constructor de la clase
        public productoViewModel()
        {
            productoRecord = new Producto();
            _productoEntity = new Producto();
            _repository = new productoRepository();
            getAll();
            productoRecord.registrosProducto.CollectionChanged += 
                new NotifyCollectionChangedEventHandler(productoRecord.RegistrosProducto_CollectionChanged);
        }
        #endregion

        #region Defición del los métodos de command
        public ICommand ResetCommand
        {
            get
            {
                if (_resetCommand == null)
                    _resetCommand = new RelayCommand(param => resetData(), null);

                return _resetCommand;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new RelayCommand(param => saveData(), null);

                return _saveCommand;
            }
        }

        public ICommand EditCommand
        {
            get
            {
                if (_editCommand == null)
                    _editCommand = new RelayCommand(param => editData((int)param), null);

                return _editCommand;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                    _deleteCommand = new RelayCommand(parametro =>deleteProducto((int)parametro), null);

                return _deleteCommand;
            }
        }
        #endregion
        
        #region Métodos del CRUD
        public void saveData()
        {
            if (productoRecord != null)
            {
                _productoEntity.Nombre = productoRecord.Nombre;
                _productoEntity.Descripcion = productoRecord.Descripcion;
                _productoEntity.Cantidad = productoRecord.Cantidad;

                try
                {
                    if (productoRecord.idProducto == 0)
                    {
                        _repository.addProducto(_productoEntity);
                        //MessageBox.Show("Nuevo producto guardado existosamente.");
                    }
                    else
                    {
                        _productoEntity.idProducto = productoRecord.idProducto;
                        _repository.updateProducto(_productoEntity);
                        //MessageBox.Show("Producto acutualizado existosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar los datos. Error: " + ex.InnerException);
                }
                finally
                {
                    resetData();
                    getAll();
                }
            }
        }
        public void resetData()
        {
            productoRecord.idProducto = 0;
            productoRecord.Nombre = string.Empty;
            productoRecord.Descripcion = string.Empty;
            productoRecord.Cantidad = -1;
            productoRecord.Existencia = null;
            productoRecord.PRecetado = null;
        }
        public void editData(int id)
        {
            var model = _repository.get(id);
            productoRecord.idProducto = model.idProducto;
            productoRecord.Nombre = model.Nombre;
            productoRecord.Descripcion = model.Descripcion;
            productoRecord.Cantidad = model.Cantidad;
        }
        public void deleteProducto(int id)
        {
            if (MessageBox.Show("Confirmación de eliminación de producto.\n¿Desea eliminar este producto?", "Eliminar producto", MessageBoxButton.YesNo)
                == MessageBoxResult.Yes)
            {
                try
                {
                    _repository.removeProducto(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar los datos. \nError: " + ex.Message);
                }
                finally
                {
                    resetData();
                    getAll();
                }
            }
        }
        #endregion
        
        #region Método para obtener todos los registros (El ObservableCollection)
        public void getAll()
        {
            productoRecord.registrosProducto = new ObservableCollection<Producto>();
            _repository.getAll().ForEach
            (
                data => productoRecord.registrosProducto.Add
                (
                    new Producto()
                    {
                        idProducto = data.idProducto,
                        Nombre = data.Nombre,
                        Descripcion = data.Descripcion,
                        Cantidad = data.Cantidad
                    }
                )
            );
        }
        #endregion

        #region Métodos de búsqueda
        public void buscarRegistro(string cadena)
        {
            productoRecord.registrosProducto = new ObservableCollection<Producto>();
            _repository.getWhere(cadena).ForEach
            (
                data => productoRecord.registrosProducto.Add
                (
                    new Producto()
                    {
                        idProducto = data.idProducto,
                        Nombre = data.Nombre,
                        Descripcion = data.Descripcion,
                        Cantidad = data.Cantidad
                    }
                )
            );
        }
        #endregion

    }
}
