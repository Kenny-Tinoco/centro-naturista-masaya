using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class Detail
    {
        private int idDetail;
        private Stock product;
        private int quantity;
        private float price;
        private float subTota = -1;

        public Detail()
        {
            
        }

    }
}