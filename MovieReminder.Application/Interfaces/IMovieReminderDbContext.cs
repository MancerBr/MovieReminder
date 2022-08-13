using Microsoft.EntityFrameworkCore;
using MovieReminder.Domain;

namespace MovieReminder.Application.Interfaces;

public interface IMovieReminderDbContext
{
    DbSet<User> Users { get; set; }
    DbSet<UserSession> UserSessions { get; set; }
    DbSet<Movie> Movies { get; set; }
    DbSet<MovieSource> MovieSources { get; set; }
    DbSet<Category> Categories { get; set; }
    DbSet<Genre> Genres { get; set; }
    DbSet<MovieGenre> MovieGenres { get; set; }
    DbSet<MovieCategory> MovieCategories { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
