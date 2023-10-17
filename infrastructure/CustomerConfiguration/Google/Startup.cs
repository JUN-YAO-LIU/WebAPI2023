using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.CustomerConfiguration.Google;

public static class Startup
{
    public static IServiceCollection ConfigureGoogleService(this IServiceCollection services, IConfiguration config)
        => services.Configure<GoogleOptions>(config.GetSection(nameof(GoogleOptions)));
}