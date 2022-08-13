using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReminder.Domain;

namespace MovieReminder.Infrastructure.EntityTypeConfigurations
{
    internal class MovieGenreConfiguration : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.HasKey(movieGenre => movieGenre.Id);
            builder.HasIndex(movieGenre => movieGenre.Id).IsUnique();

            builder.HasOne(movieGenre => movieGenre.Movie)
               .WithMany(genre => genre.MovieGenres)
               .HasForeignKey(movieGenre => movieGenre.MovieId);

            builder.HasOne(movieGenre => movieGenre.Genre)
               .WithMany(genre => genre.MovieGenres)
               .HasForeignKey(movieGenre => movieGenre.GenreId);
        }
    }
}
