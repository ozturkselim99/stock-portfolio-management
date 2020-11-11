using app.entity;
using System.Collections.Generic;

namespace app.data.Abstract
{
    public interface IStockRepository
    {
        List<Stock> GetAllStocks();
    }
}
