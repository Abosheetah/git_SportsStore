using Microsoft.AspNetCore.Mvc;
using SportsStoreApp.Models;
using SportsStoreApp.Models.Repository;

namespace SportsStoreApp.Controllers{
    public class CategoryController : Controller{
        private ICategoryRepository _repo ;
        public CategoryController(ICategoryRepository repo){
            _repo = repo;
        }

        public IActionResult List(){
            return View(_repo.Categories);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category){
            _repo.AddCategory(category);
            return RedirectToAction(nameof(List));
        }

        public IActionResult EditCategory(int id){
            ViewBag.CategoryID = id;
            return View("List",_repo.Categories);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category){
            _repo.UpdateCategory(category);
            return View(nameof(List));
        }

        public IActionResult DeleteCategory(Category category){
            _repo.DeleteCategory(category);
            return View(nameof(List));
        }

    }
}