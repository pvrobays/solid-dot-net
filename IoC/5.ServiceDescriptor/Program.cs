// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Shared.ToDo;

var services = new ServiceCollection();
//services.AddSingleton<IToDoService, ToDoService>();

var todoServiceDescriptor = new ServiceDescriptor(
    typeof(IToDoService),
    typeof(ToDoService),
    ServiceLifetime.Singleton
);
services.Add(todoServiceDescriptor);


var appServiceDescriptor = new ServiceDescriptor(typeof(Application), provider =>
{
    var todoService = provider.GetRequiredService<IToDoService>();

    return new Application(todoService);

    // or:
    // return new Application(new ToDoService());
}, ServiceLifetime.Singleton);
services.Add(appServiceDescriptor);

var serviceProvider = services.BuildServiceProvider();
var application = serviceProvider.GetRequiredService<Application>();
await application.Run();