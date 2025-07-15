using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TeamTaskList.Application.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetProjectsByUserAsync(Guid userId);
        Task<Project> CreateAsync(Project project);
        Task DeleteProjectAsync(Guid projectId);        
    }
}
