using System;
using System.Threading.Tasks;

namespace SupermarketAPI.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
