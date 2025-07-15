using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeamTaskList.Domain.Entities;
using TeamTaskList.Domain.Interfaces;
using TeamTaskList.Infra.Context;
using Task = System.Threading.Tasks.Task;

namespace TeamTaskList.Infra.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly TaskManagerDbContext _context;

        public ProjectRepository(TaskManagerDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Project>> GetByUserIdAsync(Guid userId)
        {
            return await _context.Projects
                .Where(p => p.UserId == userId)
                .ToListAsync();
        }
        public async Task<Project> CreateAsync(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return project;
        }
        public async Task DeleteAsync(Project project)
        {
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }
        public async Task<Project> GetByIdAsync(Guid projectId)  
        {
            return await _context.Projects.FindAsync(projectId);
        }
               
    }
}
