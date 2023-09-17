using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _categoryService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetCategory(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(MainCategory category)
        {
            var result = _categoryService.Add(category);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        // Category 2
        [HttpGet("setallsubcategoryone")]
        public IActionResult GetList2()
        {
            var result = _categoryService.GetAllSubcategoryOne();
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("geybyparentidsubcategoryone")]
        public IActionResult GetByParentCategoryId(int parentId)
        {
            var result = _categoryService.GetByParentCategoryIdSubcategoryOne(parentId);
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("geybyparentidsubcategorytwo")]
        public IActionResult GetByParentCategoryId3(int parentId)
        {
            var result = _categoryService.GetByParentCategoryIdSubcategoryTwo(parentId);
            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
