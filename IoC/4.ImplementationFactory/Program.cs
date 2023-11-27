// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Shared.ToDo;

var services = new ServiceCollection();

services.AddSingleton<IToDoService, ToDoService>();



services.AddSingleton<Application>(provider =>
{
    var todoService = provider.GetRequiredService<IToDoService>();

    return new Application(todoService);
    
    // or:
    // return new Application(new ToDoService());
});




var serviceProvider = services.BuildServiceProvider();
var application = serviceProvider.GetRequiredService<Application>();
await application.Run();