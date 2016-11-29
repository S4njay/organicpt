using System;

namespace OrganicPt
{
    public class Stock
    {
        public Guid StockId { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public decimal CurrentMarketPrice { get; set; }
    }
}