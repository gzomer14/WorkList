using WorkList.Domain.Models;

namespace WorkList.Application.Interfaces;

public interface IToDoAppService
{
    Task Add(ToDo item);
    void Remove(ToDo item);
    void Update(ToDo item);
    Task<List<ToDo>> GetAll();
    Task<ToDo> GetById(int id);
}