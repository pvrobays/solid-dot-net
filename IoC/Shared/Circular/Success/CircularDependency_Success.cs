using Microsoft.Extensions.DependencyInjection;

namespace Shared.Circular.Success;

public class SomeDependency(IServiceProvider serviceProvider) // ⚠️ This is an anti-pattern
{
    public void DoSomething()
    {
        var anotherDependency = serviceProvider.GetRequiredService<AnotherDependency>();
        Console.WriteLine(anotherDependency.GetMessage());
    }

    public string GetState()
    {
        return "OK";
    }
}

public class AnotherDependency(IServiceProvider serviceProvider) // ⚠️ This is an anti-pattern
{
    public string GetMessage()
    {
        var someDependency = serviceProvider.GetRequiredService<SomeDependency>();
        return $"AnotherDependency indicates the state of SomeDependency is {someDependency.GetState()}";
    }
}