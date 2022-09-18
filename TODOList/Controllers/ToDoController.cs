
using Microsoft.AspNetCore.Mvc;
using TODOList.Models;
using TODOList.Services;
using TODOList.Services.Impl;
using Task = TODOList.Models.Task;

namespace TODOList.Controllers;

public class ToDoController : Controller
{
    
    private readonly ToDoService _toDoService = new ToDoServiceImpl();
    private readonly MockToDoService _mockToDoService = new MockToDoServiceImpl();
    
    [HttpGet]
    [Route("/todo/welcome")]
    public IActionResult Welcome()
    {
        return View();
    }

    [HttpGet]
    [Route("/todo/mock/data")]
    public IActionResult Mock()
    {
        ICollection<Task> todo = _mockToDoService.CreateMockList();
        ICollection<Task> completedTasks = _mockToDoService.CreateMockCompletedList();
        return View(todo);
    }

    [HttpPost]
    [Route("/todo/task/create")]
    public IActionResult CreateTask([FromBody] ToDo toDo)
    {
        ToDo toDoCreated = _toDoService.Create(toDo);
        return Ok(toDoCreated);
    }

    [HttpGet]
    [Route("/todo/task/all")]
    public IActionResult All()
    {
        return Ok(_toDoService.FindAll());
    }

    [HttpGet]
    [Route("/todo/index/{id}")]
    public IActionResult Index(long id)
    {
        ToDo toDoFound = _toDoService.FindById(id);
        return Ok(toDoFound);
    }
}