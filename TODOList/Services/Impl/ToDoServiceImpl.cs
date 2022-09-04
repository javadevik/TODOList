using TODOList.Models;

namespace TODOList.Services.Impl;

public class ToDoServiceImpl : ToDoService
{
    private readonly ICollection<ToDo> _toDos = new List<ToDo>();
    
    private long _keyEnumerator;
    
    public ToDo Create(ToDo toDo)
    {
        toDo.Id = _keyEnumerator++;
        _toDos.Add(toDo);
        return _toDos.Contains(toDo) ? toDo : new ToDo();
    }

    public ICollection<ToDo> FindAll()
    {
        return _toDos;
    }

    public ToDo FindById(long id)
    {
        return _toDos.First(t => t.Id == id);
    }

    public ToDo Update(long id, ToDo toDo)
    {
        var itemToUpdate = FindById(id);
        itemToUpdate.Title = toDo.Title;
        itemToUpdate.Task = toDo.Task;
        return _toDos.Contains(toDo) ? toDo : new ToDo();
    }

    public void Delete(long id)
    {
    }
}
