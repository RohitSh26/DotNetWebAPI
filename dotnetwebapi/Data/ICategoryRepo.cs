using System.Collections.Generic;
using DotNetWebAPI.Models;

namespace DotNetWebAPI.Data
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetAllCategories();

        Category GetCategoryById(int id);

        void CreateCategory(Category category);

        bool SaveChanges();
    }
}