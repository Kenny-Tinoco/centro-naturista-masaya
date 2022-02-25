using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.DTO;
using System.Diagnostics.Contracts;

namespace CentroNaturistaMasaya.Model.Repository
{
    public class StockRepository
    {
        Strategy strategy;

        public StockRepository(Strategy strategy)
        {
            Contract.Requires(strategy != null);
            this.strategy = strategy;
        }

        public void addStock(StockDTO stockDTO)
        {
            Contract.Requires(stockDTO != null);
        }
    }
}
