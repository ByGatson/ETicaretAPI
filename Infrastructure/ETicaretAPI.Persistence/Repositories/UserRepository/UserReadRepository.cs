using ETicaretAPI.Application.Repositories.UserRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.UserRepository
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
