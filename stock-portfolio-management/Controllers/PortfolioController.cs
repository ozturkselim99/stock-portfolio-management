using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using stock_portfolio_management.Identity;
using stock_portfolio_management.Models;

namespace stock_portfolio_management.Controllers
{
    [Authorize]
    public class PortfolioController : Controller
    {
        private IPortfolioService _portfolioService;
        private IStockService _stockService;
        private UserManager<User> _userManager;
        public PortfolioController(IPortfolioService portfolioService, IStockService stockService, UserManager<User> userManager)
        {
            _portfolioService = portfolioService;
            _stockService = stockService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var portfolio = _portfolioService.GetPortfolioByUserId(_userManager.GetUserId(User));
            var stocks = _stockService.GetAllStocks();
            return View(new PortfolioModel()
            {
                PortfolioId = portfolio.PortfolioId,
                PortfolioItems = portfolio.PortfolioItems.Select(i => new PortfolioItemModel()
                {
                    code = i.Code,
                    quantity = i.Quantity,
                    cost = i.Cost,
                    totalBuy = (i.Quantity * i.Cost),
                    dailyChange = stocks.FirstOrDefault(a => a.code == i.Code).rate,
                    lastPrice = stocks.FirstOrDefault(a => a.code == i.Code).lastprice,
                }).ToList()
            });
        }
        [HttpPost]
        public IActionResult AddToPortfolio(string code, int quantity, double cost)
        {
            var userId = _userManager.GetUserId(User);
            _portfolioService.AddToPortfolio(userId, code, quantity, cost);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteFromPortfolio(string code)
        {
            var userId = _userManager.GetUserId(User);
            _portfolioService.DeleteFromPortfolio(userId, code);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditStockDetails(string code, int quantity, double cost)
        {
            var userId = _userManager.GetUserId(User);
            _portfolioService.EditStockDetails(userId, code, quantity, cost);
                return RedirectToAction("Index");
        }
    }
}
