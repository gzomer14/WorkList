using Microsoft.EntityFrameworkCore;
using WorkList.Domain.Interfaces;
using WorkList.Infra.Data.Context;

namespace WorkList.Infra.Data.Repository;

public class ToDoRepository : IToDoRepository
{
    private readonly WorkListContext _context;

    public ToDoRepository(WorkListContext context)
    {
        _context = context;
    }

    public async Task Add(Domain.Models.ToDo item)
    {
        await _context.ToDos.AddAsync(item);
    }

    public async Task<List<Domain.Models.ToDo>> GetAll()
    {
        return await _context.ToDos.ToListAsync();
    }

    public async Task<Domain.Models.ToDo> GetById(int id)
    {
        return await _context.ToDos.FirstOrDefaultAsync(t => t.ToDoId == id);
    }

    public void Remove(Domain.Models.ToDo item)
    {
        _context.ToDos.Remove(item);
    }

    public void Update(Domain.Models.ToDo item)
    {
        _context.ToDos.Update(item);
    }    
}