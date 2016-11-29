using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganicPt
{
    public class OrganicPtContext : IOrganicPtContext
    {
        public IList<Stock> Stocks
        {
            get
            {
                return new List<Stock>
                {
                    new Stock
                    {
                        Currency = "INR",
                        CurrentMarketPrice = 300,
                        Name = "Tata Steel",
                        StockId = Guid.NewGuid(),
                        Symbol = "tatasteel.ns"

                    },
                    new Stock
                    {
                        Currency = "INR",
                        CurrentMarketPrice = 500,
                        Name = "Tata Motors",
                        StockId = Guid.NewGuid(),
                        Symbol = "tatamotors.ns"

                    }
                };

            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}