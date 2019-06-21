using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Services.Services;

namespace SupermarketAPI.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService categoryService;

        //Constructor
        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await categoryService.ListAsync();
            return categories;
        }
    }
}
