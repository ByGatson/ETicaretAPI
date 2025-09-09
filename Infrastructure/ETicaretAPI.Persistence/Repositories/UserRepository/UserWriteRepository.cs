using ETicaretAPI.Application.Repositories.UserRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.UserRepository
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
