using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace OrganicPt
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> FetchAll();
        T GetBySymbol(string symbol);
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        void Save();
    }
}