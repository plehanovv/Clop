using Clop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clop.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Login).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Password).IsRequired();

        builder.HasData(new List<User>()
        {
            new User()
            {
                Id = 1,
                Login = "Test user1",
                Password = "hugdfgfdgdfu87gf7$#dfgddfg$g7ggf",
                CreatedAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            }
        });
    }
}