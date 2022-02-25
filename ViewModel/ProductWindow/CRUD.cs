using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel.ProductWindow
{
    internal abstract class CRUD
    {

        private ICommand _saveCommand;
        private ICommand _resetCommand;
        private ICommand _editCommand;
        private ICommand _deleteCommand;

        public ICommand resetCommand
        {
            get
            {
                if (_resetCommand == null)
                    _resetCommand = new RelayCommand(parameter => resetData(), null);

                return _resetCommand;
            }
        }

        public ICommand saveCommand
        {
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new RelayCommand(parameter => saveData(), null);

                return _saveCommand;
            }
        }

        public ICommand editCommand
        {
            get
            {
                if (_editCommand == null)
                    _editCommand = new RelayCommand(parameter => editData((int)parameter), null);

                return _editCommand;
            }
        }

        public ICommand deleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                    _deleteCommand = new RelayCommand(parameter => deleteData((int)parameter), null);

                return _deleteCommand;
            }
        }

        public virtual void saveData()
        {
        }

        public virtual void resetData()
        {
        }

        public virtual void editData(int id)
        {
        }

        public virtual void deleteData(int id)
        {
        }
    }
}
