using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stock_portfolio_management.Models
{
    public class PortfolioModel
    {
        public int PortfolioId { get; set; }
        public List<PortfolioItemModel> PortfolioItems { get; set; }

        public double TotalGain()
        {
            return PortfolioItems.Sum(i => @Math.Round((i.lastPrice * i.quantity) - i.totalBuy, 2));
        }
        public double CurrentBalance()
        {
            return PortfolioItems.Sum(i => @Math.Round((i.cost * i.quantity), 2))+TotalGain();
        }
    }
    public class PortfolioItemModel
    {
        public string code { get; set; }
        public double lastPrice { get; set; }
        public double dailyChange{ get; set; }
        public double cost { get; set; }
        public int quantity { get; set; }
        public double totalBuy { get; set; }
        public double gain { get; set; }
    }
}
