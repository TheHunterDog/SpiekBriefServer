using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class TaskContext:DbContext
{
    public DbSet<Task> Tasks { get; set; }

    public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task>().Property(t => t.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Task>().HasKey(t=>t.Id);
        base.OnModelCreating(modelBuilder);
    }

}