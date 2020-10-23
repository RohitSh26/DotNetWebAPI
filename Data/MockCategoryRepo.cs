using System.Collections.Generic;
using DotNetWebAPI.Models;

namespace DotNetWebAPI.Data
{
    class MockCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> GetAllCategories()
        {
            var Categories = new List<Category>
            {
                new Category
                {
                    Id = 0,
                    Name = "Initial",
                    Description = "A mock Category",
                    IsActive = true
                },
                new Category
                {
                    Id = 0,
                    Name = "Second",
                    Description = "A second mock Category",
                    IsActive = false
                }
            };
            return Categories;
        }

        public Category GetCategoryById(int id)
        {
            return new Category
            {
                Id = 0,
                Name = "Initial",
                Description = "A mock Category",
                IsActive = true
            };
        }
    }
}