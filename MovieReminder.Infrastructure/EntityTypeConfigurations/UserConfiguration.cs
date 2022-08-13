using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReminder.Domain;

namespace MovieReminder.Infrastructure.EntityTypeConfigurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);
        builder.HasIndex(user => user.Id).IsUnique();

        builder.Property(user => user.FirstName).HasMaxLength(50);

        builder.Property(user => user.LastName).HasMaxLength(50);

        builder.Property(user => user.Email).HasMaxLength(100).IsRequired();
        builder.HasIndex(user => user.Email).IsUnique();

        builder.Property(user => user.Password).HasMaxLength(255).IsRequired();

        builder.Property(user => user.CreatedAt)
            .HasColumnType("date")
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAdd();

        builder.Property(user => user.UpdatedAt)
            .HasColumnType("date")
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAddOrUpdate();
    }
}
