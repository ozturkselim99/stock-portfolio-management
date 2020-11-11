using System.Diagnostics;
using app.business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stock_portfolio_management.Models;

namespace stock_portfolio_management.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IStockService _stockService;
        public HomeController(ILogger<HomeController> logger, IPortfolioService portfolioService, IStockService stockService)
        {
            _logger = logger;
            _stockService = stockService;
        }
        public IActionResult Index()
        {
            var model = new StockListViewModel()
            {
                stocks = _stockService.GetAllStocks()
            };
            return View(model);
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
