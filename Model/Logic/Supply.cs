using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class Supply : Transaction
    {
        private Provider provider;
        

        public Supply()
        {

        }

        public Supply(Provider provider)
        {
            Contract.Requires(provider != null);
            this.provider = provider;
        }


        public Provider Provider
        {
            set { provider = value; }
            get { return provider; }
        }

        public void makeSupply()
        {
            getTotal();
            increaseQuantityInProducts();
            saveChange();
        }

        void increaseQuantityInProducts()
        {
        }
    }
}
