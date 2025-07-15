using Microsoft.AspNetCore.Mvc;
using TeamTaskList.Application.Interfaces;
using TeamTaskList.Application.Services;

namespace TeamTaskList.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("{projectId}")]
        public async Task<IActionResult> GetTaskByProject(Guid projectId)
        {
            var tasks = await _taskService.GetTaskByProjectAsync(projectId);
            return Ok(tasks);
        }

        [HttpDelete("{taskId}")]
        public async Task<IActionResult> DeleteTask(Guid taskId)
        {
            await _taskService.DeleteTaskAsync(taskId);
            return NoContent();
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateTask(TaskDto dto)
        //{
        //    var task = await _taskService.CreateTaskAsync(dto);
        //    return Ok(task);
        //}

        //[HttpPut("{taskId}")]
        //public async Task<IActionResult> UpdateTask(Guid taskId, TaskUpdateDto dto)
        //{
        //    await _taskService.UpdateTaskAsync(taskId, dto);
        //    return NoContent();
        //}

    }
}
