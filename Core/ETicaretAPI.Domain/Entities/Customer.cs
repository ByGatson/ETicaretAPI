using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string UserName { get; set; } = "";

        public ICollection<Order>? Orders { get; set; }

    }
}
