using Shared;
using Shared.ToDo;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services
            .AddApplicationService()
            .AddTodoService();
    }
    
    private static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddSingleton<Application>();
        return services;
    }

    private static IServiceCollection AddTodoService(this IServiceCollection services)
    {
        services.AddSingleton<IToDoService, ToDoService>();
        return services;
    }
}