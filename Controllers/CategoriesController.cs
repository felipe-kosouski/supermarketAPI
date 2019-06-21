using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Services.Services;
using SupermarketAPI.Resources;

namespace SupermarketAPI.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        //Constructor
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await categoryService.ListAsync();
            var resources = mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);

            return resources;
        }
    }
}
