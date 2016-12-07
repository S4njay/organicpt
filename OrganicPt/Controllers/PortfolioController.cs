using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganicPt.Controllers
{
    public class PortfolioController : Controller
    {
        public IRepository<Stock> StockRepository { get; set; }

        public PortfolioController(IRepository<Stock> repository)
        {
            StockRepository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }        
    }
}