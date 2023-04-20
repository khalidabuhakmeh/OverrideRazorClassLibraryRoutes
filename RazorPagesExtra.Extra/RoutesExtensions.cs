using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace RazorPagesExtra.Extra;

public static class RoutesExtensions
{
    public static IServiceCollection SetPrivacyUrl(this IServiceCollection services, string route)
    {
        services.Configure<RazorPagesOptions>(opt =>
        {
            // Override an imported Razor Class Library
            // Razor Pages Route
            opt.Conventions.AddAreaPageRoute(
                areaName: "Extra",
                pageName: "/Privacy",
                route: route);
        });
        
        return services;
    }
}