// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Shared.IdGenerator;

var services = new ServiceCollection();

services.AddScoped<IdGenerator>();

var serviceProvider = services.BuildServiceProvider();

var idGen1 = serviceProvider.GetRequiredService<IdGenerator>();
var idGen2 = serviceProvider.GetRequiredService<IdGenerator>();

Console.WriteLine($"ID of idGen1 ({idGen1.Guid}) == ID of idGen2 ({idGen2.Guid})");

var serviceScopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();

using (var serviceScope = serviceProvider.CreateScope()) //Avoid using serviceProvider directly!
{
    var idGen = serviceScope.ServiceProvider.GetRequiredService<IdGenerator>();
    Console.WriteLine($"ID of idGen =  {idGen.Guid}");
}

using (var serviceScope = serviceScopeFactory.CreateScope()) //Better use IServiceScopeFactory
{
    var idGen = serviceScope.ServiceProvider.GetRequiredService<IdGenerator>();
    Console.WriteLine($"ID of idGen =  {idGen.Guid}");
}
