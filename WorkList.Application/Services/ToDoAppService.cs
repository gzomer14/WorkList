using WorkList.Application.Interfaces;
using WorkList.Domain.Interfaces;

namespace WorkList.Application.Services;

public class ToDoAppService : IToDoAppService
{
    private readonly IToDoRepository _repository;

    public ToDoAppService(IToDoRepository repository)
    {
        _repository = repository;
    }

    public async Task Add(Domain.Models.ToDo item)
    {
        await _repository.Add(item);
    }

    public async Task<List<Domain.Models.ToDo>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<Domain.Models.ToDo> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public void Remove(Domain.Models.ToDo item)
    {
        _repository.Remove(item);
    }

    public void Update(Domain.Models.ToDo item)
    {
        _repository.Update(item);
    }
}