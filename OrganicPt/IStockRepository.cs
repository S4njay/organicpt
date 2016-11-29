using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganicPt
{
    public class StockRepository : IRepository<Stock>
    {
        public IOrganicPtContext context; 

        public StockRepository(IOrganicPtContext organicPtContext)
        {
            context = organicPtContext;
        }

        public void Delete(Stock item)
        {
            context.Stocks.Remove(item);
        }

        public IEnumerable<Stock> FetchAll()
        {
            return context.Stocks;
        }

        public Stock GetByID(Guid Id)
        {
            return context.Stocks.FirstOrDefault(s => s.StockId == Id);
        }

        public void Insert(Stock item)
        {
            context.Stocks.Add(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Stock item)
        {
            var oldItem = context.Stocks.FirstOrDefault(s => s.StockId == item.StockId);
            if(oldItem != null)
            {
                var position = context.Stocks.IndexOf(oldItem);
                context.Stocks.RemoveAt(position);
                context.Stocks.Insert(position, item);
            }

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~StockRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}