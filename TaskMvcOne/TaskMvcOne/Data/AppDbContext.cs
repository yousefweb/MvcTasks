using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskMvcOne.Models;

namespace TaskMvcOne.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
     
    }
}
