using ETicaretAPI.Application;
using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Application.Repositories.OrderRepository;
using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Application.Repositories.UserRepository;
using ETicaretAPI.Persistence.Configurations;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories.CustomerRepository;
using ETicaretAPI.Persistence.Repositories.OrderRepository;
using ETicaretAPI.Persistence.Repositories.ProductRepository;
using ETicaretAPI.Persistence.Repositories.UserRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConfigurationString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
