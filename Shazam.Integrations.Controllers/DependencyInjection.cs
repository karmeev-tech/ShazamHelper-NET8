using Mapster;
using MapsterMapper;
using MetaMusic.Integrations.Facade;
using MetaMusic.Integrations.Facade.Contracts;
using MetaMusic.Integrations.Facade.Mapping;

namespace MetaMusic.Integrations;

public static class DependencyInjection
{
    public static IServiceCollection AddFacades(this IServiceCollection services)
    {
        return services.AddSingleton<IShazamIntegrationFacade, ShazamIntegrationFacade>()
        .AddSingleton<IFileFacade, FileFacade>();
    }

    public static IServiceCollection AddMappings(this IServiceCollection services)
    {
        var typeAdapterConfig = TypeAdapterConfig.GlobalSettings;
        typeAdapterConfig.Register();
        services.AddSingleton(typeAdapterConfig);
        services.AddSingleton<IMapper, ServiceMapper>();
        return services;
    }
}