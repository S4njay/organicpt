using System;
using System.Collections.Generic;

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
                        CurrentMarketPrice = NewMethod(),
                        Name = "Tata Steel",
                        StockId = new Guid("B12610EA-A818-4F42-90F6-A50C1573464C".ToLower()),
                        Symbol = "nse:tatasteel"

                    },
                    new Stock
                    {
                        Currency = "INR",
                        CurrentMarketPrice = 500,
                        Name = "Tata Motors",
                        StockId = new Guid("61E147C7-C39E-40C3-B624-EE9F97A847D5".ToLower()),
                        Symbol = "nse:tatamotors"
                    }
                };
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private static int NewMethod()
        {
            return new Random().Next(1, 100);
        }
    }
}