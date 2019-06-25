using System;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Repositories;
using SupermarketAPI.Persistence.Contexts;

namespace SupermarketAPI.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
