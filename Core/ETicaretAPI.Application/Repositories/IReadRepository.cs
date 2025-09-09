
using ETicaretAPI.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);
        Task<T?> GetSingleAsync(Expression<Func<T, bool>> predicate);
        Task<T?> GetByIdAsync(string id);
    }
}
