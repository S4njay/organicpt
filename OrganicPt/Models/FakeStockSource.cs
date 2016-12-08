using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace OrganicPt
{
    public class FakeStockSource : ILiveStockSource
    {
        public string[] Urls
        {
            get
            {
                return new string[] { "",""};
            }

            set { }         
        }

        public string GetCmp(string url)
        {
            return new Random().Next(1, 1000).ToString();
        }

        public IEnumerable<Stock> GetWorldMarkets(string url)
        {
            return new List<Stock>
                {
                 new Stock{ Name = "Shanghai",Symbol = "SHA:0000001" },
                 new Stock{ Name = "Nikkei 225",Symbol = "INDEXNIKKEI:NI225" },
                 new Stock{ Name = "HANG SENG INDEX",Symbol = "INDEXHANGSENG:HSI" },
                 new Stock{ Name = "TSEC",Symbol = "INDEXNIKKEI:NI225" },
                 new Stock{ Name = "FTSE 100",Symbol = "INDEXNIKKEI:NI225" },
                 new Stock{ Name = "EURO STOXX 50",Symbol = "INDEXNIKKEI:NI225" },
                 new Stock{ Name = "CAC 40",Symbol = "INDEXNIKKEI:NI225" },
                 new Stock{ Name = "S&P TSX",Symbol = "INDEXNIKKEI:NI225" },
                };
        }
    }
}