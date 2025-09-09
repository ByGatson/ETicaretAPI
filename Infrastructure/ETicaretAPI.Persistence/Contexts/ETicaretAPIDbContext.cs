using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Contexts
{
    public class ETicaretAPIDbContext : DbContext
    {
        public ETicaretAPIDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var entity in datas)
            {
                Console.WriteLine(datas);
                _ = entity.State switch
                {
                    EntityState.Added => entity.Entity.CreatedTime = DateTime.UtcNow,
                    EntityState.Modified => entity.Entity.UpdatedTime = DateTime.UtcNow,
                    EntityState.Detached => throw new NotImplementedException(),
                    EntityState.Unchanged => throw new NotImplementedException(),
                    EntityState.Deleted => throw new NotImplementedException(),
                    _ => throw new NotImplementedException(),
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}