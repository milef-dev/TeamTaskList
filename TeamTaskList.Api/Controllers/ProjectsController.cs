using Microsoft.AspNetCore.Mvc;
using TeamTaskList.Api.Requests;
using TeamTaskList.Application.Interfaces;
using TeamTaskList.Domain.Entities;

namespace TeamTaskList.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetProjectsByUser(Guid userId)
        {
            var result = await _projectService.GetProjectsByUserAsync(userId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProjectsByUser([FromBody] CreateProjectRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var project = new Project
            {
                Id = Guid.NewGuid(), 
                Nome = request.Nome,
                UserId = request.UserId,
                Tasks = null
            };

            var createdProject = await _projectService.CreateAsync(project);
            return CreatedAtAction(nameof(GetById), new { id = createdProject.Id }, createdProject);
        }

        [HttpDelete("{projectId}")]
        public async Task<IActionResult> DeleteProject(Guid projectId)
        {
            await _projectService.DeleteProjectAsync(projectId);
            return NoContent();
        }

        [HttpGet("user/{id}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> GetById(Guid id)
        {
            // Pode implementar busca por ID depois
            return Ok(); // placeholder
        }

    }
}