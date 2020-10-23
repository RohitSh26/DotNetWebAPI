using System.Collections.Generic;
using AutoMapper;
using DotNetWebAPI.Data;
using DotNetWebAPI.Dtos;
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
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Category>> GetAllCategories()
        {
            var categoryItems = _repository.GetAllCategories();

            return Ok(_mapper.Map<IEnumerable<CategoryReadDto>>(categoryItems));
        }

        [HttpGet("{id}")]
        public ActionResult <CategoryReadDto> GetCategoryById(int id)
        {
            var categoryItem = _repository.GetCategoryById(id: id);

            if(categoryItem != null)
            {
                return Ok(_mapper.Map<CategoryReadDto>(categoryItem));
            }
                

            return NotFound();
        }
    }
}