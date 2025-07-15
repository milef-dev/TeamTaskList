using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Application.Interfaces;
using TeamTaskList.Domain.Entities;
using TeamTaskList.Domain.Interfaces;
using Task = System.Threading.Tasks.Task; // força o 'Task' ser sempre o tipo assíncrono

namespace TeamTaskList.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<IEnumerable<TeamTaskList.Domain.Entities.Task>> GetTaskByProjectAsync(Guid projectId)
        {
            //return (IEnumerable<Task>)await _taskRepository.GetByProjectIdAsync(projectId);
            return await _taskRepository.GetByProjectIdAsync(projectId);

        }

        //public Task<IEnumerable<TeamTaskList.Domain.Entities.Task>> GetTaskByProjectAsync(Guid projectId)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task DeleteTaskAsync(Guid taskId)
        {
            var task = await _taskRepository.GetByIdAsync(taskId);
            if (task == null)
                throw new Exception("Tarefa não encontrada.");

            await _taskRepository.DeleteAsync(task);
        }
        
        //public IEnumerable<Task> ListTaskProject(Guid projectId)
        //{
        //    return _tasks.Where(t => t.ProjectId == projectId);
        //}

        //public Task CreateTask(Guid projectId, Task task, Guid userId, out string erro)
        //{
        //    erro = string.Empty;

        //    var taskAndProject = _tasks.Count(t => t.ProjectId == projectId);
        //    if (taskAndProject >= 20)
        //    {
        //        erro = "O projeto atingiu o limite máximo de 20 tarefas.";
        //        return null;
        //    }

        //    task.Id = Guid.NewGuid();
        //    task.ProjectId = projectId;

        //    task.History.Add(new TaskHistory
        //    {
        //        Id = Guid.NewGuid(),
        //        ModifiedField = "Tarefa criada",
        //        ModificationDate = DateTime.UtcNow,
        //        UserId = userId
        //    });

        //    _tasks.Add(task);
        //    return task;
        //}

        //public bool UpdateTask(Task task, string alterDescription, Guid userId)
        //{
        //    var taskExists = _tasks.FirstOrDefault(t => t.Id == task.Id);
        //    if (taskExists == null)
        //        return false;

        //    taskExists.Status = task.Status;
        //    taskExists.Description = task.Description;
        //    taskExists.DueDate = task.DueDate;

        //    taskExists.History.Add(new TaskHistory
        //    {
        //        Id = Guid.NewGuid(),
        //        ModifiedField = alterDescription,
        //        ModificationDate = DateTime.UtcNow,
        //        UserId = userId
        //    });

        //    return true;
        //}

        //public bool DeleteTask(Guid taskId)
        //{
        //    var task = _tasks.FirstOrDefault(t => t.Id == taskId);
        //    if (task == null)
        //        return false;

        //    return _tasks.Remove(task);
        //}
    }
}
