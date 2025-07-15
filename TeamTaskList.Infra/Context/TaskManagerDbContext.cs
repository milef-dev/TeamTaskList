using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Task = TeamTaskList.Domain.Entities.Task;

namespace TeamTaskList.Infra.Context
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) : base(options) { }

        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Task> Tasks => Set<Task>();
        public DbSet<TaskHistory> Historys => Set<TaskHistory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagerDbContext).Assembly);
        }
    }
}
