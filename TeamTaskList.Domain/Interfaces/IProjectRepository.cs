using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TeamTaskList.Domain.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetByUserIdAsync(Guid userId);
        Task<Project> CreateAsync(Project project);
        Task DeleteAsync(Project project);
        Task<Project> GetByIdAsync(Guid projectId); 
       
    }
}
