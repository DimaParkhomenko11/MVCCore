using System.Collections.Generic;

namespace MVCCore.Infrastructure.Data
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}