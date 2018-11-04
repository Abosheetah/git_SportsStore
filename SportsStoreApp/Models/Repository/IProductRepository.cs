using System.Linq;

namespace SportsStoreApp.Models.Repository{
    public interface IProductRepository
    {
        IQueryable<Product> Products{get;}
    }
}