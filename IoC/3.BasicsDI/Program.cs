//We use microsoft's dependency injection library

using Microsoft.Extensions.DependencyInjection;
using Shared.ToDo;

//We create a service collection = a list of all registered dependencies (services) with their lifetime
var services = new ServiceCollection();

services.AddSingleton<IToDoService, ToDoService>();
services.AddSingleton<Application>();

// Or, in the opposite order. The order doesn't matter. e.g.:
// services.AddSingleton<Application>();
// services.AddSingleton<IToDoService, ToDoService>();

//Telling the service collection we want to build a DI container from the list (=service provider)
var serviceProvider = services.BuildServiceProvider();

//Any services.Add...() call after this line will be ignored!
services.AddSingleton<IToDoService, FakeToDoService>(); //ignored!

//Retrieving our application from the DI container
var application = serviceProvider.GetRequiredService<Application>();

await application.Run();
