using Microsoft.Extensions.DependencyInjection;
using MovieReminder.Application.Services.Authentication;

namespace MovieReminder.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
