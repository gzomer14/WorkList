using WorkList.Domain.Models;

namespace WorkList.Domain.Interfaces;

public interface IToDoRepository
{
    Task Add(ToDo item);
    void Remove(ToDo item);
    void Update(ToDo item);
    Task<List<ToDo>> GetAll();
    Task<ToDo> GetById(int id);
}