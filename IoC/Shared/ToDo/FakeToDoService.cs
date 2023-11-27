using Shared.ToDo.Models;

namespace Shared.ToDo;

public class FakeToDoService : IToDoService
{
    public void AddToDoItem(ToDoItem toDoItem)
    {
        Console.WriteLine("Faking adding an item");
    }

    public IEnumerable<ToDoItem> GetToDoItems()
    {
        Console.WriteLine("Faking returning results an item");

        yield return new ToDoItem()
        {
            Title = "Fake ToDo Item",
            Description = "This is a fake ToDo Item",
            IsDone = false
        };

        yield return new ToDoItem()
        {
            Title = "Fake ToDo Item 2",
            Description = "This is a fake ToDo Item 2",
            IsDone = false
        };
    }
}