
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddRangeAsync(List<T> models);
        Task<bool> AddAsync(T model);
        Task<bool> RemoveAsync(string id);
        bool RemoveRange(List<T> models);
        bool Remove(T model);
        Task<int> SaveAsync();
        bool Update(T model);

    }
}
