// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Shared.ToDo;

var services = new ServiceCollection();



services.TryAddSingleton<IToDoService, ToDoService>();
services.TryAddSingleton<Application>();


//Replace a service
services.RemoveAll(typeof(IToDoService));
services.TryAddSingleton<IToDoService, FakeToDoService>();

//⚠️ Remove by service descriptor works with reference. The below code won't remove anything!!
services.Remove(new ServiceDescriptor(typeof(IToDoService), typeof(FakeToDoService), ServiceLifetime.Singleton));

var serviceProvider = services.BuildServiceProvider();
var application = serviceProvider.GetRequiredService<Application>();
await application.Run();
