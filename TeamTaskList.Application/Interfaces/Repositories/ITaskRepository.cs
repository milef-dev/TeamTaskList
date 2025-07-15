using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Domain.Entities;
using Task = TeamTaskList.Domain.Entities.Task;

namespace TeamTaskList.Application.Interfaces.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Task>> GetTaskByProjectAsync(int projectId);

    }
}
