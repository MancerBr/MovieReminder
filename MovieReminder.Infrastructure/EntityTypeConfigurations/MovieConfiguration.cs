using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReminder.Domain;

namespace MovieReminder.Infrastructure.EntityTypeConfigurations;

internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(movie => movie.Id);
        builder.HasIndex(movie => movie.Id).IsUnique();

        builder.Property(movie => movie.Name).HasMaxLength(100).IsRequired();

        builder.Property(movie => movie.Image).HasMaxLength(255);

        builder.Property(movie => movie.Description).HasColumnType("text");

        builder.Property(movie => movie.CreatedAt)
            .HasColumnType("date")
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAdd();

        builder.Property(movie => movie.UpdatedAt)
            .HasColumnType("date")
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAddOrUpdate();

        builder.HasOne(movie => movie.User)
            .WithMany(user => user.Movies)
            .HasForeignKey(movie => movie.UserId);
    }
}
