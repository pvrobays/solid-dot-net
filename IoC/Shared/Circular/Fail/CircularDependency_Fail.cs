namespace Shared.Circular.Fail;

public class SomeDependency(AnotherDependency anotherDependency)
{
    public void DoSomething()
    {
        Console.WriteLine(anotherDependency.GetMessage());
    }

    public string GetState()
    {
        return "OK";
    }
}

public class AnotherDependency(SomeDependency someDependency)
{
    public string GetMessage()
    {
        return $"AnotherDependency indicates the state of SomeDependency is {someDependency.GetState()}";
    }
}