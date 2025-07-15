using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Domain.Entities;
using Task = TeamTaskList.Domain.Entities.Task;
//using Task = System.Threading.Tasks.Task;

namespace TeamTaskList.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Task>> GetByProjectIdAsync(Guid projectId);
        System.Threading.Tasks.Task DeleteAsync(Task taskId);
        Task<Task> GetByIdAsync(Guid projectId);


    }
}
