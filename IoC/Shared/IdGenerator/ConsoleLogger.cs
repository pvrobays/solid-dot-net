namespace Shared.IdGenerator;

public interface IConsoleLogger
{
    void Log(string message);
}

public class ConsoleLogger(IdGenerator idGenerator) : IConsoleLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"ConsoleLogger {idGenerator.Guid} says: {message}");
    }
}