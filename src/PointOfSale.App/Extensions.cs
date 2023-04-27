using Microsoft.Extensions.DependencyInjection;

namespace PointOfSale.App;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
