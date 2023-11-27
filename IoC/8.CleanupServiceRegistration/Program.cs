// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Shared.ToDo;

//We create a service collection = a list of all registered dependencies (services) with their lifetime
var services = new ServiceCollection();


services.AddApplicationServices();

var serviceProvider = services.BuildServiceProvider();
var application = serviceProvider.GetRequiredService<Application>();
await application.Run();
