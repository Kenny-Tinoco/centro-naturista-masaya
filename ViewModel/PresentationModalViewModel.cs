using MasayaNaturistCenter.Command;
using MasayaNaturistCenter.Logic;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MasayaNaturistCenter.ViewModel
{
    public class PresentationModalViewModel : ViewModelBase
    {
        private ObservableCollection<PresentationDTO> _presentationList;
        private PresentationLogic presentationLogic;

        public PresentationDTO presentation { get; set; }

        public string titleBar
        {
            get
            {
                return "Presentaciones";
            }
        }

        public ICommand exitCommand { get; }
        public ICommand saveCommand { get; }
        public ICommand deleteCommand { get; }
        private ICommand _editCommand;
        private ICommand _resetCommand;

        public PresentationModalViewModel(INavigationService closeModalNavigationService, PresentationLogic parameter)
        {
            presentationLogic = parameter;
            presentation = presentationLogic.currentPresentation;
            exitCommand = new ExitModalCommand(closeModalNavigationService);
            saveCommand = new SaveCommand(presentationLogic);
            getPresentationList(presentationLogic.getAll());
        }
        public ObservableCollection<PresentationDTO> presentationList
        {
            get
            {
                return _presentationList;
            }
            set
            {
                _presentationList = value;
                OnPropertyChanged(nameof(presentationList));
            }
        }
        private void getPresentationList( List<BaseDTO> list )
        {
            var stocks = new ObservableCollection<PresentationDTO>();
            list.ForEach(element => stocks.Add((PresentationDTO)element));
            presentationList = stocks;
        }

        public ICommand resetCommand
        {
            get
            {
                if (_resetCommand == null)
                    _resetCommand = new RelayCommand(parametro => reset(), null);

                return _resetCommand;
            }
        }
        public void reset()
        {
            presentation = new PresentationDTO();
            OnPropertyChanged(nameof(presentation));
        }
        public ICommand editCommand
        {
            get
            {
                if (_editCommand == null)
                    _editCommand = new RelayCommand(parameter => edit((PresentationDTO)parameter), null);

                return _editCommand;
            }
        }
        public void edit(PresentationDTO parameter)
        {
            presentation = parameter;
            OnPropertyChanged(nameof(presentation));
        }
    }
}
