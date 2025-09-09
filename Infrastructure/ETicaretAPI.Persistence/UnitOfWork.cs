using ETicaretAPI.Application;
using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Application.Repositories.OrderRepository;
using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ETicaretAPIDbContext _context;
        public ICustomerReadRepository CustomerReadRepository { get; private set; }
        public IOrderReadRepository OrderReadRepository { get; private set; }
        public IProductReadRepository ProductReadRepository { get; private set; }
        public ICustomerWriteRepository CustomerWriteRepository { get; private set; }
        public IOrderWriteRepository OrderWriteRepository { get; private set; }
        public IProductWriteRepository ProductWriteRepository { get; private set; }

        public UnitOfWork(ETicaretAPIDbContext context,
                          ICustomerReadRepository customerReadRepository,
                          IOrderReadRepository orderReadRepository,
                          IProductReadRepository productReadRepository,
                          ICustomerWriteRepository customerWriteRepository,
                          IOrderWriteRepository orderWriteRepository,
                          IProductWriteRepository productWriteRepository)
        {
            _context = context;
            CustomerReadRepository = customerReadRepository;
            OrderReadRepository = orderReadRepository;
            ProductReadRepository = productReadRepository;
            CustomerWriteRepository = customerWriteRepository;
            OrderWriteRepository = orderWriteRepository;
            ProductWriteRepository = productWriteRepository;
        }

        public void Dispose()
        {

        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
