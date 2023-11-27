using Shared.ToDo.Models;

namespace Shared.ToDo;

public class Application(IToDoService toDoService)
{
    public Task Run()
    {
        Console.WriteLine("Adding some to do items...");
        toDoService.AddToDoItem(new ToDoItem { Title = "Learn DI", Description = "Learn DI with .NET" }); 
        toDoService.AddToDoItem(new ToDoItem { Title = "Do some exercises", Description = "Do some exercises with DI" });
        Console.WriteLine("Added some to do items!");
        Console.WriteLine("Listing all items:");
        foreach (var item in toDoService.GetToDoItems())
        {
            Console.WriteLine($"Title: {item.Title}, Description: {item.Description}, IsDone: {item.IsDone}");
        }
        Console.WriteLine("Application finished!");
        
        return Task.CompletedTask;
    }
}