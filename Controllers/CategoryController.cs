using System.Collections.Generic;
using DotNetWebAPI.Data;
using DotNetWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebAPI.Controllers
{
    // base class is a mvc controller without view support
    // api/category
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _repository;

        public CategoryController(ICategoryRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Category>> GetAllCategories()
        {
            var categoryItems = _repository.GetAllCategories();
            return Ok(categoryItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Category> GetCategoryById(int id)
        {
            var categoryItem = _repository.GetCategoryById(id: id);
            return Ok(categoryItem);
        }
    }
}