using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCCore.Infrastructure.Data;

namespace MVCCore.Infrastructure.Configuration
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired();
            builder.HasMany(u => u.Orders).WithOne(u => u.User).HasForeignKey(u => u.UserId);
        }
    }
}