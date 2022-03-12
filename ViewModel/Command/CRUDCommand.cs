using MasayaNaturistCenter.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel.Command
{
    public class CRUDCommand : ViewModelBase
    {
        private ICommand _saveCommand;
        private ICommand _deleteCommand;
        private ICommand _updateCommand;

        public ICommand saveCommand
        {
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new RelayCommand(param => saveData((StockDTO)param), null);
                return _saveCommand;
            }
        }

        public ICommand deleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                    _deleteCommand = new RelayCommand(param => deleteElement((int)param), null);

                return _deleteCommand;
            }
        }

        public ICommand updateCommand
        {
            get
            {
                if (_updateCommand == null)
                    _updateCommand = new RelayCommand(param => updateElement(), null);

                return _updateCommand;
            }
        }

        public virtual void saveData(StockDTO parameter)
        {
        }

        public virtual void deleteElement(int parameter)
        {
        }

        public virtual void updateElement()
        {
        }

    }
}
