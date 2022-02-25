using MasayaNaturistCenter.Model;
using MasayaNaturistCenter.Model.Repository;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
{
    public class existenciaViewModel
    {
        private ICommand _saveCommand;
        private ICommand _resetCommand;
        private ICommand _editCommand;
        private ICommand _deleteCommand;

        private existenciaRepository _repository;
        productoRepository _repositoryProducto = new productoRepository();
        presentacionRepository _repositoryPresentacion = new presentacionRepository();
        private Existencia _existenciaEntity = null;
        /*Esta variable es auxiliar, sólo para el método agregar*/


        public existenciaViewModel()
        {
            existenciaRecord = new Existencia();
            productoRecord = new Producto();
            presentacionRecord = new Presentacion();
            _existenciaEntity = new Existencia();
            _repository = new existenciaRepository();
            getAll();
            getAllNames();
            existenciaRecord.registrosExistencia.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(existenciaRecord.RegistrosExistencia_CollectionChanged);
        }


        public Producto productoRecord
        {
            set;
            get;
        }

        public Presentacion presentacionRecord
        {
            set;
            get;
        }

        public Existencia existenciaRecord
        {
            get;
            set;
        }

        public Existencia existenciaSelected
        {
            get;
            set;
        }

        public CNMEntities existenciaEntities
        {
            get;
            set;
        }

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
                    _deleteCommand = new RelayCommand(parametro => deleteExistencia((int)parametro), null);

                return _deleteCommand;
            }
        }


        public void saveData()
        {
            if (existenciaRecord != null)
            {
                _existenciaEntity.idProducto = existenciaRecord.idProducto;
                _existenciaEntity.idPresentacion = existenciaRecord.idPresentacion;
                _existenciaEntity.Precio = existenciaRecord.Precio;
                _existenciaEntity.Cantidad = existenciaRecord.Cantidad;
                _existenciaEntity.Caducidad = existenciaRecord.Caducidad;
                _existenciaEntity.fechaEntrada = existenciaRecord.fechaEntrada;
                _existenciaEntity.Producto = existenciaRecord.Producto;
                _existenciaEntity.Presentacion = existenciaRecord.Presentacion;
                try
                {
                    if (existenciaRecord.idExistencia == 0)
                    {
                        _repository.addExistencia(_existenciaEntity);
                        //MessageBox.Show("Nuevo producto guardado existosamente.");
                    }
                    else
                    {
                        _existenciaEntity.idExistencia = _existenciaEntity.idExistencia;
                        _repository.addExistencia(_existenciaEntity);
                        //MessageBox.Show("Producto acutualizado existosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar los datos. \nError: " + ex.Message);
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
            existenciaRecord.idExistencia = 0;
            existenciaRecord.idProducto = 0;
            existenciaRecord.idPresentacion = 0;
            existenciaRecord.Producto = null;
            existenciaRecord.Presentacion = null;
            existenciaRecord.Precio = 0;
            existenciaRecord.Cantidad = 0;
            existenciaRecord.Caducidad = null;
            existenciaRecord.fechaEntrada = null;
        }
        
        public void editData(int id)
        {
            var model = _repository.get(id);
            existenciaRecord.idExistencia = model.idExistencia;
            existenciaRecord.idProducto = model.idProducto;
            existenciaRecord.idPresentacion = model.idPresentacion;
            existenciaRecord.Precio = model.Precio;
            existenciaRecord.Cantidad = model.Cantidad;
            existenciaRecord.Caducidad = model.Caducidad;
            existenciaRecord.fechaEntrada = model.fechaEntrada;
            existenciaRecord.Producto = model.Producto;
            existenciaRecord.Presentacion = model.Presentacion;
        }
        
        public void deleteExistencia(int id)
        {
            if (MessageBox.Show("Confirmación de eliminación de producto.\n¿Desea eliminar este producto?", "Eliminar presentación", MessageBoxButton.YesNo)
                == MessageBoxResult.Yes)
            {
                try
                {
                    _repository.removeExistencia(id);
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

        public void getAll()
        {
            existenciaRecord.registrosExistencia = new ObservableCollection<Existencia>();
            _repository.getAll().ForEach
            (
                data => existenciaRecord.registrosExistencia.Add
                (
                    new Existencia()
                    {
                        idExistencia = data.idExistencia,
                        idProducto = data.idProducto,
                        idPresentacion = data.idPresentacion,
                        Precio = data.Precio,
                        Cantidad = data.Cantidad,
                        Caducidad = data.Caducidad,
                        fechaEntrada = data.fechaEntrada,
                        Producto = data.Producto,
                        Presentacion = data.Presentacion
                    }
                )
            ); 
        }

        public void getAllNames()
        {
            productoRecord.nombresProducto = new ObservableCollection<string>();
            presentacionRecord.nombresPresentacion = new ObservableCollection<string>();

            _repositoryProducto
                .getAll()
                .ForEach
                (
                    data => productoRecord.nombresProducto.Add(data.Nombre)
                );

            _repositoryPresentacion
                .getAll()
                .ForEach
                (
                    data => presentacionRecord.nombresPresentacion.Add(data.Nombre)
                );
        }
       
        public void productoSeleccionado()
        {
            var model = _repositoryProducto.get(productoRecord.idProducto + 1);
            productoRecord.Nombre = model.Nombre;
            productoRecord.Descripcion = model.Descripcion;
        }
        
        public void presentacionSeleccionado()
        {
            var model = _repositoryPresentacion.get(presentacionRecord.idPresentacion + 1);
            presentacionRecord.Nombre = model.Nombre;
        }

        public void buscarRegistro(string cadena)
        {
            existenciaRecord.registrosExistencia = new ObservableCollection<Existencia>();
            _repository.getWhere(cadena).ForEach
            (
                data => existenciaRecord.registrosExistencia.Add
                (
                    new Existencia()
                    {
                        idExistencia = data.idExistencia,
                        idProducto = data.idProducto,
                        idPresentacion = data.idPresentacion,
                        Precio = data.Precio,
                        Cantidad = data.Cantidad,
                        Caducidad = data.Caducidad,
                        fechaEntrada = data.fechaEntrada,
                        Producto = data.Producto,
                        Presentacion = data.Presentacion
                    }
                )
            );
        }

    }
}
