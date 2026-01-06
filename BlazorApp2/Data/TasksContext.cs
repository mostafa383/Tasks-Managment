using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class TasksContext:DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options) : base(options) { }
        
            public DbSet<Taskk> Tasks { get; set; }
    }
    
    
}
