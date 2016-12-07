namespace OrganicPt
{
    public interface ILiveStockSource
    {
        string BaseUrl { get;}
        string StockUrl { get; set; }
        string DownloadString();
    }
}