using ETicaretAPI.Persistence.Contexts;


namespace ETicaretAPI.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly ETicaretAPIDbContext context;
        public BaseRepository(ETicaretAPIDbContext context)
        {
            this.context = context;
        }
    }
}
