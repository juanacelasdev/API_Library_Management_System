using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            
            builder.HasKey(user => user.Id);

            builder.Property(user => user.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(user => user.LastName)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(user => user.Email)
                .IsRequired()
                .HasMaxLength(120);

            builder.Property(user => user.Password)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(user => user.Role)
                .IsRequired();

            builder.Property(user => user.IsActive)
                .IsRequired();

            builder.HasIndex(user => user.Email)
                .IsUnique();

             builder.ToTable("Users");
        }
    }
}