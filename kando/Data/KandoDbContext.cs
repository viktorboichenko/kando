using kando.Models;
using Microsoft.EntityFrameworkCore;

namespace kando.Data;

public class KandoDbContext : DbContext
{
    public KandoDbContext(DbContextOptions<KandoDbContext> options) : base(options)
    {
    }
    
    public DbSet<TaskItem> Tasks { get; set; }
    public DbSet<AppUser> Users { get; set; }
}