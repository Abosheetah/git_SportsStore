using System.Collections.Generic;
using System.Linq;

namespace SportsStoreApp.Models.Repository{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>{
            new Product{ID = 1 , Name = "Cap" , Category = "Football", Price = 56, Description ="for Football players"},
            new Product{ID = 2 , Name = "Gloves" , Category = "Boxing", Price = 156, Description =""},
            new Product{ID = 3 , Name = "Shoes" , Category = "Badminton", Price = 250, Description =""},
            new Product{ID = 4 , Name = "Towels" , Category = "Gymnastics", Price = 102, Description =""},
            new Product{ID = 5 , Name = "Golf bag" , Category = "Canoeing", Price = 630, Description =""}
            
        }.AsQueryable();
    }
}