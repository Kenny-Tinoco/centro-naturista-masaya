using CentroNaturistaMasaya.Model.Repository;
using MasayaNaturistCenter.Model.DTO;
using MasayaNaturistCenter.ViewModel.ProductWindow;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.ViewModel
{
    internal class StockViewModel : CRUD
    {
        private StockDTO _userStockObject;
        private StockRepository stockRepository;

        public StockViewModel()
        {
        }

        public StockDTO userStockObject
        {
            get => _userStockObject;
            set => _userStockObject = value;
        }

        public override void saveData()
        {
            Contract.Requires(userStockObject != null);

            StockDTO stockObject = new StockDTO();

            stockObject.idProduct = userStockObject.idProduct;
            stockObject.idPresentation = userStockObject.idPresentation;
            stockObject.price = userStockObject.price;
            stockObject.quantity = userStockObject.quantity;
            stockObject.entryDate = userStockObject.entryDate;
            stockObject.expiration = userStockObject.expiration;

            //_existenciaEntity.Producto = existenciaRecord.Producto;
            //_existenciaEntity.Presentacion = existenciaRecord.Presentacion;
            try
            {
                addStock(stockObject);
            }
            catch (System.Exception ex)
            {
                System.Windows.MessageBox.Show("Ocurrió un error al guardar los datos. \nError: " + ex.Message);
            }
            finally
            {
                resetData();
                getRecords();
            }
        } 

        private void addStock(StockDTO stockDTO)
        {
            if (stockDTO.idProductStock != 0)
            {
                stockDTO.idProductStock = userStockObject.idProductStock;
            }

            stockRepository.addStock(stockDTO);
        }
    
        public void getRecords()
        {

        }
    }
}
