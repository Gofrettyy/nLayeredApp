using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abtracts;
using Business.Concretes;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
         ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)

        {
            _categoryService = categoryService;
        }
        [HttpPost] 
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest createCategoryRequest)
        { var result = await _categoryService.Add(createCategoryRequest);
            return Ok(result); }
       
        [HttpGet]
        public async Task<IActionResult> GetListAsync()
        { 
            var result = await _categoryService.GetListAsync(); 
            return Ok(result);
        }
        
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateCategoryRequest updateCategoryRequest)
        {
            var result = await _categoryService.UpdateAsync(updateCategoryRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteCategoryRequest deleteCategoryRequest)
        {
            var result = await _categoryService.DeleteAsync(deleteCategoryRequest);
            return Ok(result);
        }
    }
    
}

