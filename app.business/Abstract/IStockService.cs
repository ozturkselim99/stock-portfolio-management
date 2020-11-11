using app.entity;
using System.Collections.Generic;

namespace app.business.Abstract
{
    public interface IStockService
    {
        List<Stock> GetAllStocks();
    }
}
