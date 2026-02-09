using kando.Data;
using kando.Models;
using Microsoft.EntityFrameworkCore;
using TaskStatus = kando.Models.TaskStatus;

namespace kando.Services;

public class TaskService(KandoDbContext context)
{
    public async Task<List<TaskItem>> GetAllAsync()
    {
        return await context.Tasks
            .Include(t => t.Assignee)
            .OrderByDescending(t => t.CreatedAt)
            .ToListAsync();
    }
    
    public async Task CreateAsync(TaskItem task)
    {
        task.Status = TaskStatus.Todo; 
        task.CreatedAt = DateTime.UtcNow;
        
        context.Tasks.Add(task);
        await context.SaveChangesAsync();
    }
}