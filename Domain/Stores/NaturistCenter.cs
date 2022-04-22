using Domain.Entities;
using System.Collections.ObjectModel;

namespace Domain.Stores
{
    public class NaturistCenter
    {
        private ObservableCollection<Stock> stocks;
        private ObservableCollection<Product> products;
        private ObservableCollection<Presentation> presentations;


        public void Refresh()
        {

        }
    }
}
