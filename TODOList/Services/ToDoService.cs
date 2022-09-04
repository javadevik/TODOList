using TODOList.Models;

namespace TODOList.Services;

public interface ToDoService
{
    ToDo Create(ToDo toDo);
    ICollection<ToDo> FindAll();
    ToDo FindById(long id);
    ToDo Update(long id, ToDo toDo);
    void Delete(long id);
}