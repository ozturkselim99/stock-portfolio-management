using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace app.data.Concrete.EfCore
{
    public class EfCorePortfolioRepository : EfCoreGenericRepository<Portfolio, SPMContext>, IPortfolioRepository
    {
        public void AddToPortfolio(string userId, string code, int quantity, double cost)
        {
            using (var context = new SPMContext())
            {
                var portfolio = GetPortfolioByUserId(userId);
                context.portfolioItems.Add(new PortfolioItem()
                {
                    PortfolioId = portfolio.PortfolioId,
                    Code = code,
                    Quantity = quantity,
                    Cost = cost
                });
                context.SaveChanges();
            }
        }
        public void DeleteFromPortfolio(int portfolioId, string code)
        {
            using (var context = new SPMContext())
            {
                var cmd = @"delete from portfolioItems where PortfolioId=@p0 and Code=@p1";
                context.Database.ExecuteSqlRaw(cmd, portfolioId, code);
            }
        }
        public void EditStockDetails(int portfolioId, string code, int quantity, double cost)
        {
            using (var context = new SPMContext())
            {
                var portfolioItem = context.portfolioItems.FirstOrDefault(i => i.Code == code && i.PortfolioId == portfolioId);
                portfolioItem.Quantity = quantity;
                portfolioItem.Cost = cost;
                context.SaveChanges();
            }
        }
        public Portfolio GetPortfolioByUserId(string userId)
        {
            using (var context = new SPMContext())
            {
                return context.portfolios.Include(i => i.PortfolioItems).FirstOrDefault(i => i.UserId == userId);
            }
        }
    }
}
