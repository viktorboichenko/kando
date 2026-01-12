using kando.Models;
using kando.Services;
using Microsoft.AspNetCore.Mvc;
using TaskStatus = kando.Models.TaskStatus;

namespace kando.Controllers;

public class TasksController(TaskService service) : Controller
{
    public async Task<IActionResult> Index()
    {
        var tasks = await service.GetAllAsync();
        return View(tasks);
    }
}