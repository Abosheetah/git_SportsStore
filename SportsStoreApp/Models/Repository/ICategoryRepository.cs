using System.Linq;

namespace SportsStoreApp.Models.Repository{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories {get;}
        void AddCategory(Category category);
    }
}