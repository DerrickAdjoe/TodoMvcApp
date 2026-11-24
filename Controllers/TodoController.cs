using Microsoft.AspNetCore.Mvc;
using TodoMvcApp.Models;

namespace TodoMvcApp.Controllers;

public class TodoController : Controller
{
    public IActionResult Index()
    {
        var sampleTasks = new List<TodoItem>
        {
            new TodoItem
            {
                Id = 1,
                Title = "Review Chapter 4 Razor Syntax",
                IsCompleted = false
            },
            new TodoItem
            {
                Id = 2,
                Title = "Configure unified Program.cs routing",
                IsCompleted = true
            }
        };

        return View(sampleTasks);
    }
}