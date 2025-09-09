using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ReadRepository<T> : BaseRepository, IReadRepository<T> where T : BaseEntity
    {
        public ReadRepository(ETicaretAPIDbContext context) : base(context) { }

        public DbSet<T> Table => context.Set<T>();

        public async Task<List<T>> GetAllAsync() => await Table.ToListAsync();

        public async Task<T?> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));

        public async Task<T?> GetSingleAsync(Expression<Func<T, bool>> predicate) => await Table.FirstOrDefaultAsync(predicate);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate) => Table.Where(predicate);
    }
}
