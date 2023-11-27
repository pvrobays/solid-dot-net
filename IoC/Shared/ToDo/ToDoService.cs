using Shared.ToDo.Models;

namespace Shared.ToDo;

public interface IToDoService
{
    void AddToDoItem(ToDoItem toDoItem);
    
    IEnumerable<ToDoItem> GetToDoItems();
}

public class ToDoService : IToDoService
{
    private readonly List<ToDoItem> _toDoItems = new();
    
    public void AddToDoItem(ToDoItem toDoItem)
    {
        _toDoItems.Add(toDoItem);
    }

    public IEnumerable<ToDoItem> GetToDoItems() => _toDoItems;
}