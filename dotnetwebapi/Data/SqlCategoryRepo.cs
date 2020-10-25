using System;
using System.Collections.Generic;
using System.Linq;
using DotNetWebAPI.Models;
using Microsoft.Extensions.Caching.Memory;

namespace DotNetWebAPI.Data
{
    public class SqlCategoryRepo : ICategoryRepo
    {
        private readonly CategoryContext _context;

        public SqlCategoryRepo(CategoryContext context)
        {
            _context = context;
        }

        public void CreateCategory(Category category)
        {
            if(category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            _context.Categories.Add(category);
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

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}