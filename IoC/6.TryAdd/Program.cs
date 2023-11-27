// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Shared.ToDo;

var services = new ServiceCollection();


services.AddSingleton<Application>();

services.AddSingleton<IToDoService, ToDoService>();
// services.AddSingleton<IToDoService, FakeTodoService>();


// services.TryAddSingleton<IToDoService, ToDoService>();
// services.TryAddSingleton<IToDoService, FakeToDoService>();


// services.TryAddEnumerable(new ServiceDescriptor(typeof(IToDoService), typeof(ToDoService), ServiceLifetime.Singleton));
// services.TryAddEnumerable(new ServiceDescriptor(typeof(IToDoService), typeof(FakeToDoService), ServiceLifetime.Singleton));

var serviceProvider = services.BuildServiceProvider();
var application = serviceProvider.GetRequiredService<Application>();
await application.Run();