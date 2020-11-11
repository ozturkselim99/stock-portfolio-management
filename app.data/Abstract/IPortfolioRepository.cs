using app.entity;

namespace app.data.Abstract
{
    public interface IPortfolioRepository : IRepository<Portfolio>
    {
        Portfolio GetPortfolioByUserId(string userId);
        void AddToPortfolio(string userId, string code, int quantity, double cost);
        void DeleteFromPortfolio(int portfolioId, string code);
        void EditStockDetails(int portfolioId, string code, int quantity, double cost);
    }
}
