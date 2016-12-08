using System.Collections.Generic;

namespace OrganicPt
{
    public interface ILiveStockSource
    {
        string GetCmp(string url);        
        IEnumerable<Stock> GetWorldMarkets(string url);
        string[] Urls { get; set; }
    }
}