using Blazored.LocalStorage;

namespace WhiteElephant.Blazor;

public static class DependencyInjection
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    { 
        services.AddBlazoredLocalStorage();
        services.AddRazorComponents().AddInteractiveServerComponents();

        return services;
    }
}