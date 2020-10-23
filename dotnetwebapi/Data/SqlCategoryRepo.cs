using System.Collections.Generic;
using System.Linq;
using DotNetWebAPI.Models;

namespace DotNetWebAPI.Data
{
    public class SqlCategoryRepo : ICategoryRepo
    {
        private readonly CategoryContext _context;

        public SqlCategoryRepo(CategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var item = _context.Categories.ToList();
            return item;
        }

        public Category GetCategoryById(int id)
        {
            var item = _context.Categories.FirstOrDefault(item => item.Id == id);

            return item;
        }
    }
}