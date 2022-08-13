using Microsoft.EntityFrameworkCore;
using MovieReminder.Application.Interfaces;
using MovieReminder.Domain;
using MovieReminder.Infrastructure.EntityTypeConfigurations;

namespace MovieReminder.Infrastructure;

public class MovieReminderDbContext : DbContext, IMovieReminderDbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserSession> UserSessions { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieSource> MovieSources { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<MovieGenre> MovieGenres { get; set; }
    public DbSet<MovieCategory> MovieCategories { get; set; }

    public MovieReminderDbContext(DbContextOptions<MovieReminderDbContext> dbContextOptions) : base(dbContextOptions)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserSessionConfiguration());
        modelBuilder.ApplyConfiguration(new MovieConfiguration());
        modelBuilder.ApplyConfiguration(new MovieSourceConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new GenreConfiguration());
        modelBuilder.ApplyConfiguration(new MovieGenreConfiguration());
        modelBuilder.ApplyConfiguration(new MovieCategoryConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
