using System.Collections.Generic;

namespace OrganicPt
{
    public interface IOrganicPtContext
    {
        IList<Stock> Stocks { get;}
    }
}