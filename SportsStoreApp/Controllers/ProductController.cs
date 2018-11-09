using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStoreApp.Models;
using SportsStoreApp.Models.Repository;

namespace SportsStoreApp.Controllers{
    public class ProductController : Controller{
        private IProductRepository _repo;
        private ICategoryRepository _carRepo ; 
        public int PageSize = 4;
        
        public ProductController(IProductRepository repo,ICategoryRepository catRepo){
            _repo = repo;
            _carRepo = catRepo;
        }
        public ViewResult List(int productPage = 1){
            ViewBag.Categories = _carRepo.Categories;
            return View(_repo.Products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product){
            _repo.AddProduct(product);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult UpdateProduct(int key){
            return View(_repo.GetProduct(key));
        }

        public IActionResult UpdateProduct(Product product){
            _repo.UpdateProduct(product);
            return RedirectToAction(nameof(List));
        }
    }
}