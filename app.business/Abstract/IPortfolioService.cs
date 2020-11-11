using app.entity;

namespace app.business.Abstract
{
    public interface IPortfolioService
    {
        void InitializePortfolio(string userId);
        Portfolio GetPortfolioByUserId(string userId);
        void AddToPortfolio(string userId, string code, int quantity, double cost);
        void DeleteFromPortfolio(string userId, string code);
        void EditStockDetails(string userId, string code, int quantity, double cost);
    }
}
