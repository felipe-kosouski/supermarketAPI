using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Services.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
