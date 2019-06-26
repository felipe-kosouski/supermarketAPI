using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Communication;
using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Services.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
    }
}
