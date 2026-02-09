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
    
    [HttpPost]
    public async Task<IActionResult> Create(TaskItem task)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction(nameof(Index));
        }
        await service.CreateAsync(task);
        return RedirectToAction(nameof(Index));
    }
}