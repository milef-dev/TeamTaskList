using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeamTaskList.Domain.Entities;
using TeamTaskList.Domain.Interfaces;
using TeamTaskList.Infra.Context;
//using Task = System.Threading.Tasks.Task;

namespace TeamTaskList.Infra.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerDbContext _context;

        public TaskRepository(TaskManagerDbContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task<IEnumerable<TeamTaskList.Domain.Entities.Task>> GetByProjectIdAsync(Guid projetoId)
        {
            return await _context.Tasks
                .Include(t => t.History)
                .Where(t => t.ProjectId == projetoId)
                .ToListAsync();
        }

        public async System.Threading.Tasks.Task DeleteAsync(TeamTaskList.Domain.Entities.Task task)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
        }

        public async Task<Domain.Entities.Task> GetByIdAsync(Guid projectId)
        {
            return await _context.Tasks.FindAsync(projectId);
        }
       
    }
}
