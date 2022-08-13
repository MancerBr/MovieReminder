using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieReminder.Application.Interfaces;

namespace MovieReminder.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["DbConnection"];

        services.AddDbContext<MovieReminderDbContext>(o => o.UseNpgsql(connectionString));
        services.AddScoped<IMovieReminderDbContext>(provider => provider.GetService<MovieReminderDbContext>());

        return services;
    }
}
