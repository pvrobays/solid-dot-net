namespace Shared.ToDo.Models;

public class ToDoItem
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public bool IsDone { get; set; }
}