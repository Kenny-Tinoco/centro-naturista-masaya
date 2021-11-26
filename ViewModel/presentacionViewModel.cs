using CentroNaturistaMasaya.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CentroNaturistaMasaya.Model.Repository;
using System.Windows;
using System;
using System.Collections.Specialized;

namespace CentroNaturistaMasaya.ViewModel
{
    public class presentacionViewModel
    {

        #region Definición de los atributos
        private ICommand _saveCommand;
        private ICommand _resetCommand;
        private ICommand _editCommand;
        private ICommand _deleteCommand;
        public Presentacion presentacionSelected { get; set; } /*Almacena al producto selecionado en el datagrid*/
        private presentacionRepository _repository;
        private Presentacion _presentacionEntity = null;
        public Presentacion presentacionRecord { get; set; }
        public CNMEntities presentacionEntities { get; set; }
        #endregion

        #region Constructor de la clase
        public presentacionViewModel()
        {
            presentacionRecord = new Presentacion();
            _presentacionEntity = new Presentacion();
            _repository = new presentacionRepository();
            getAll();
            presentacionRecord.registrosPresentacion.CollectionChanged += new NotifyCollectionChangedEventHandler(presentacionRecord.RegistrosPresentacion_CollectionChanged);
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
            if (presentacionRecord != null)
            {
                _presentacionEntity.Nombre = _presentacionEntity.Nombre;

                try
                {
                    if (_presentacionEntity.idPresentacion == 0)
                    {
                        _repository.addPresentacion(_presentacionEntity);
                        //MessageBox.Show("Nuevo producto guardado existosamente.");
                    }
                    else
                    {
                        _presentacionEntity.idPresentacion = _presentacionEntity.idPresentacion;
                        _repository.updatePresentacion(_presentacionEntity);
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
            presentacionRecord.idPresentacion = 0;
            presentacionRecord.Nombre = string.Empty;
        }
        public void editData(int id)
        {
            var model = _repository.get(id);
            presentacionRecord.idPresentacion = model.idPresentacion;
            presentacionRecord.Nombre = model.Nombre;
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
            presentacionRecord.registrosPresentacion = new ObservableCollection<Presentacion>();
            _repository.getAll().ForEach
            (
                data => presentacionRecord.registrosPresentacion.Add
                (
                    new Presentacion()
                    {
                        idPresentacion = data.idPresentacion,
                        Nombre = data.Nombre
                    }
                )
            );
        }
        #endregion

        #region Métodos de búsqueda
        public void buscarRegistro(string cadena)
        {
            presentacionRecord.registrosPresentacion = new ObservableCollection<Presentacion>();
            _repository.getWhere(cadena).ForEach
            (
                data => presentacionRecord.registrosPresentacion.Add
                (
                    new Presentacion()
                    {
                        idPresentacion = data.idPresentacion,
                        Nombre = data.Nombre
                   }
                )
            );
        }
        #endregion

    }
}
