
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepositoryNoTracking<T> : IReadRepository<T> where T : BaseEntity
    {
    }
}
