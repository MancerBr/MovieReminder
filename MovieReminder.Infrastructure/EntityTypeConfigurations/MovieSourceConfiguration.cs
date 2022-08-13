using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReminder.Domain;

namespace MovieReminder.Infrastructure.EntityTypeConfigurations;

internal class MovieSourceConfiguration : IEntityTypeConfiguration<MovieSource>
{
    public void Configure(EntityTypeBuilder<MovieSource> builder)
    {
        builder.HasKey(movieSource => movieSource.Id);
        builder.HasIndex(movieSource => movieSource.Id).IsUnique();

        builder.Property(movieSource => movieSource.Name).HasMaxLength(100).IsRequired();

        builder.Property(movieSource => movieSource.Link).HasMaxLength(100);

        builder.Property(movieSource => movieSource.CreatedAt)
            .HasColumnType("date")
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAdd();

        builder.Property(movieSource => movieSource.UpdatedAt)
            .HasColumnType("date")
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAddOrUpdate();

        builder.HasOne(movieSource => movieSource.Movie)
           .WithMany(movie => movie.movieSources)
           .HasForeignKey(movieSource => movieSource.MovieId);
    }
}
