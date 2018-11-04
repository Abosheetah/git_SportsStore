using Microsoft.AspNetCore.Mvc;
using SportsStoreApp.Models.Repository;

namespace SportsStoreApp.Controllers{
    public class ProductController : Controller{
        private IProductRepository _repo;
        public ProductController(IProductRepository repo){
            _repo = repo;
        }
        public ViewResult List() => View(_repo.Products);
    }
}