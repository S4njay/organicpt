using HtmlAgilityPack;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace OrganicPt.Controllers
{
    public class InfoController : ApiController
    {
        public ILiveStockSource Source { get; set;}
        public IRepository<Stock> StockRepository { get; set;}
        private static readonly ILog log = LogManager.GetLogger(typeof(HttpApplication));


        public InfoController(ILiveStockSource source, IRepository<Stock> repo)
        {
            Source = source;
            StockRepository = repo;
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> GetAllStocks()
        {
            return StockRepository.FetchAll();
        }

        public HttpResponseMessage GetCmp(string symbol)
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent(Source.GetCmp(Source.Urls[0] + symbol));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");               
            return response;

        }

        public HttpResponseMessage GetWorldMarkets()
        {
           return Request.CreateResponse(
                HttpStatusCode.OK, 
                Source.GetWorldMarkets(Source.Urls[1]), 
                Request.GetConfiguration());
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
