using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
