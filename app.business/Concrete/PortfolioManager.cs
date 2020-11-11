using app.business.Abstract;
using app.data.Abstract;
using app.entity;

namespace app.business.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        private IPortfolioRepository _portfolioRepository;
        public PortfolioManager(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }
        public void AddToPortfolio(string userId, string code, int quantity, double cost)
        {
            var portfolio = GetPortfolioByUserId(userId);
            if (portfolio != null)
            {
                var index = portfolio.PortfolioItems.FindIndex(i => i.Code == code);
                if (index < 0)
                {
                    _portfolioRepository.AddToPortfolio(userId, code, quantity, cost);
                }
            }
        }
        public void DeleteFromPortfolio(string userId, string code)
        {
            var portfolio = GetPortfolioByUserId(userId);
            if (portfolio != null)
            {
                _portfolioRepository.DeleteFromPortfolio(portfolio.PortfolioId, code);
            }
        }
        public void EditStockDetails(string userId, string code, int quantity, double cost)
        {
            var portfolio = GetPortfolioByUserId(userId);
            if (portfolio != null)
            {
                _portfolioRepository.EditStockDetails(portfolio.PortfolioId, code, quantity, cost);
            }
        }
        public Portfolio GetPortfolioByUserId(string userId)
        {
            return _portfolioRepository.GetPortfolioByUserId(userId);
        }
        public void InitializePortfolio(string userId)
        {
            _portfolioRepository.Create(new Portfolio() { UserId = userId });
        }
    }
}
