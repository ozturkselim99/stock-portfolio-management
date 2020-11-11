using app.business.Abstract;
using app.data.Abstract;
using app.entity;
using System.Collections.Generic;

namespace app.business.Concrete
{
    public class StockManager : IStockService
    {
        private IStockRepository _stockRepository;
        public StockManager(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }
        public List<Stock> GetAllStocks()
        {
            return _stockRepository.GetAllStocks();
        }
    }
}
