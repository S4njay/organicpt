using System;
using System.Collections.Generic;

namespace OrganicPt
{
    public class OrganicPtContext : IOrganicPtContext
    {
        public IList<Stock> Stocks { get {
                return new List<Stock>
                {
                    new Stock
                    {
                        Name = "Tata Steel",
                        Symbol = "nse:tatasteel"

                    },
                    new Stock
                    {
                        Name = "Tata Motors",
                        Symbol = "nse:tatamotors"
                    }
                };
            } set { } }
    }
}