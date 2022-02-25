namespace MasayaNaturistCenter.Model.DTO
{
    internal class PresentationsDTO
    {
        private int _idPresentation;
        private string _name;

        public int idPresentation
        { 
            get => _idPresentation; 
            set => _idPresentation = value; 
        }

        public string name 
        { 
            get => _name; 
            set => _name = value; 
        }
    }
}