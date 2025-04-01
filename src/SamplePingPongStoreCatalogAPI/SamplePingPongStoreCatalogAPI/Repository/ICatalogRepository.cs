using SamplePingPongStoreCatalogAPI.Models;
using System.Collections.Generic;

namespace SamplePingPongStoreCatalogAPI.Repository
{
    public interface ICatalogRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Remove(Product product);
        int GetNextId();
    }
}
