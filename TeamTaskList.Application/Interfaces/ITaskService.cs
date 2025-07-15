using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TeamTaskList.Application.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<TeamTaskList.Domain.Entities.Task>> GetTaskByProjectAsync(Guid projectId);
        Task DeleteTaskAsync(Guid taskId);

    }
}
