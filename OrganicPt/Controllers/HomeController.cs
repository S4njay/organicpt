using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganicPt.Controllers
{
    public class HomeController : Controller
    {
        public IRepository<Stock> StockRepository { get; set; } 
        public HomeController(IRepository<Stock> stockRepository)
        {
            StockRepository = stockRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var stocks = StockRepository.FetchAll();
            return View(stocks);
        }
    }
}
