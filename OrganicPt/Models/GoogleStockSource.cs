using HtmlAgilityPack;
using System;
using System.Net;

namespace OrganicPt
{
    public class GoogleStockSource : ILiveStockSource
    {
        public string BaseUrl
        {
            get
            {
                return "https://www.google.com/finance?q=";
            }
        }

        public string StockUrl { get; set; }

        public string DownloadString()
        {
            if (string.IsNullOrWhiteSpace(StockUrl))
                throw new Exception("please provide the stock url");
            var htmlDoc = new HtmlDocument(); 
            using (var client = new WebClient())
            {
                htmlDoc.LoadHtml(client.DownloadString(BaseUrl + StockUrl));
            }

            return htmlDoc.GetElementbyId("price-panel").SelectSingleNode("//span[contains(@id,'ref_')]").InnerText;
        }        
    }
}