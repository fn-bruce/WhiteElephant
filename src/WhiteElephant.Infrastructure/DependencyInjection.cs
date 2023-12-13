using Microsoft.Extensions.DependencyInjection;
using WhiteElephant.Domain.Person;
using WhiteElephant.Infrastructure.Repositories;

namespace WhiteElephant.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IPersonRepository, PersonRepository>();
        
        return services;
    }
}