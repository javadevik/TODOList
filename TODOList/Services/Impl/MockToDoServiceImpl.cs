using Task = TODOList.Models.Task;

namespace TODOList.Services.Impl;

public class MockToDoServiceImpl : MockToDoService
{
    public ICollection<Task> CreateMockList()
    {
        return CreateListOfTasks();
    }

    public ICollection<Task> CreateMockCompletedList()
    {
        return CreateListOfTasks();
    }

    private ICollection<Task> CreateListOfTasks()
    {
        ICollection<Task> todos = new List<Task>();
        
        var task1 = new Task(1, "Task1", "Description1", DateTime.Now);
        todos.Add(task1);
        
        var task2 = new Task(2, "Task2", "Description2", DateTime.Now);
        todos.Add(task2);
        
        var task3 = new Task(3, "Task3", "Description3", DateTime.Now);
        todos.Add(task3);
        
        var task4 = new Task(4, "Task4", "Description4", DateTime.Now);
        todos.Add(task4);
        
        var task5 = new Task(5, "Task5", "Description5", DateTime.Now);
        todos.Add(task5);

        return todos;
    }
}