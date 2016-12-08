using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace OrganicPt
{
    public class GoogleStockSource : ILiveStockSource
    {
        public string[] Urls
        {
            get
            {
                return new string[] { "https://www.google.com/finance?q=", "https://www.google.com/finance" };
            }

            set { }
        }
        public string GetCmp(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new Exception("please provide the stock url");
            var htmlDoc = new HtmlDocument(); 
            using (var client = new WebClient())
            {
                htmlDoc.LoadHtml(client.DownloadString(url));
            }

            try
            {
                return htmlDoc.GetElementbyId("price-panel").SelectSingleNode("//span[contains(@id,'ref_')]").InnerText;
            }
            catch
            {
                return htmlDoc.GetElementbyId("currency_value").SelectSingleNode("//span[contains(@class,'bld')]").InnerText;
            }
            
        }

        public IEnumerable<Stock> GetWorldMarkets(string url)
        {
            var htmlDoc = new HtmlDocument();
            using (var client = new WebClient())
            {
                htmlDoc.LoadHtml(client.DownloadString(url));
            }

            var stocks = new List<Stock>();
            var rows = htmlDoc.DocumentNode.SelectNodes("//td[@class='symbol']/a");

            foreach (var row in rows)
            {
                var stock = new Stock();
                stock.Symbol = row.GetAttributeValue("href","");
                if (stock.Symbol.Contains("&")) stock.Symbol = stock.Symbol.Split('&')[0];
                if(stock.Symbol.Contains("?q="))    stock.Symbol = stock.Symbol.Replace("?q=", "?").Split('?')[1];
                stock.Name = row.InnerText.IndexOf(" ") > -1 ? row.InnerText.Substring(0, row.InnerText.IndexOf(" ")) : row.InnerText;
                stocks.Add(stock);
            }

            return stocks;
        }
    }
}