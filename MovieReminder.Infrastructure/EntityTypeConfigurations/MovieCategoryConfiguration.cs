using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReminder.Domain;

namespace MovieReminder.Infrastructure.EntityTypeConfigurations;

internal class MovieCategoryConfiguration : IEntityTypeConfiguration<MovieCategory>
{
    public void Configure(EntityTypeBuilder<MovieCategory> builder)
    {
        builder.HasKey(movieCategory => movieCategory.Id);
        builder.HasIndex(movieCategory => movieCategory.Id).IsUnique();

        builder.HasOne(movieCategory => movieCategory.Movie)
            .WithMany(category => category.MovieCategories)
            .HasForeignKey(movieCategory => movieCategory.MovieId);

        builder.HasOne(movieCategory => movieCategory.Category)
            .WithMany(category => category.MovieCategories)
            .HasForeignKey(movieCategory => movieCategory.CategoryId);
    }
}
