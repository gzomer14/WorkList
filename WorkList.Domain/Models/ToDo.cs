namespace WorkList.Domain.Models;

public class ToDo
{
    public int ToDoId { get; set; }
    public string? Message { get; set; }
    public DateTime ExpirationDate { get; set; }
    public DateTime InsertDate { get; set; } = DateTime.Now;
    public string? UserName { get; set; }
    public bool IsEnabled { get; set; }
}