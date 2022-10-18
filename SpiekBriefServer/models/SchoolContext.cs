using Microsoft.EntityFrameworkCore;

namespace SpiekBriefServer.models;

public class SchoolContext:DbContext
{
 public DbSet<Student> Students { get; set; }

 public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
  modelBuilder.Entity<Student>().Property(student => student.id).ValueGeneratedOnAdd();
  modelBuilder.Entity<Student>().HasKey(student => student.id);
  base.OnModelCreating(modelBuilder);
 }
}