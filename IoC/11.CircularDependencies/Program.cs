// See https://aka.ms/new-console-template for more information

/// ⚠️⚠️⚠️⚠️ Always avoid circular dependencies when possible ⚠️⚠️⚠️⚠️
/// in 99.9% of the cases, circular dependencies are a sign of a bad design
/// In that case, see if you can refactor your class architecture to avoid circular dependencies
/// Often a parent class can be extracted which mediates its child classes to avoid circular dependencies


using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Shared.Circular.Fail;

var services = new ServiceCollection();

services.TryAddSingleton<SomeDependency>();
services.TryAddSingleton<AnotherDependency>();

var serviceProvider = services.BuildServiceProvider();

var someDependency = serviceProvider.GetRequiredService<SomeDependency>();

someDependency.DoSomething();