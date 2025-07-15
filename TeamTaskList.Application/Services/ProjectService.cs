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
    public class ProjectService : IProjectService
    {
        //private readonly List<Project> _projects;
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<Project>> GetProjectsByUserAsync(Guid userId)
        {
            return await _projectRepository.GetByUserIdAsync(userId);
        }
        public async Task<Project> CreateAsync(Project project)
        {
            var created = await _projectRepository.CreateAsync(project);
            return created;
        }
        public async Task DeleteProjectAsync(Guid projectId)
        {
            var project = await _projectRepository.GetByIdAsync(projectId);
            if (project == null)
                throw new Exception("Projeto não encontrado.");

            await _projectRepository.DeleteAsync(project);
        }

        //public Project CreateProject(Project project)
        //{
        //    project.Id = Guid.NewGuid();
        //    project.CreatedAt = DateTime.UtcNow;
        //    _projectRepository.Add(project);
        //    return project;
        //}

        //public bool DeleteProject(Guid projectId, out string erro)
        //{
        //    var project = _projectRepository.GetById(projectId);
        //    if (project == null)
        //    {
        //        erro = "Projeto não encontrado.";
        //        return false;
        //    }

        //    _projectRepository.Delete(project);
        //    erro = string.Empty;
        //    return true;
        //}
    }


    //public IEnumerable<Project> ListProjectUsuario(Guid userId)
    //{
    //    return _projects.Where(p => p.UserId == userId);
    //}

    //public Project CreateProject(Project project)
    //{
    //    project.Id = Guid.NewGuid();
    //    _projects.Add(project);
    //    return project;
    //}

    //public bool DeleteProject(Guid projectId, out string erro)
    //{
    //    erro = string.Empty;
    //    var project = _projects.FirstOrDefault(p => p.Id == projectId);
    //    if (project == null)
    //    {
    //        erro = "Projeto não encontrado.";
    //        return false;
    //    }

    //    if (project.Tasks.Any(t => t.Status != Domain.Enums.TaskStatus.Concluida))
    //    {
    //        erro = "Projeto possui tarefas pendentes. Conclua ou remova as tarefas antes de excluir o projeto.";
    //        return false;
    //    }

    //    _projects.Remove(project);
    //    return true;
    //}

    //public Task<IEnumerable<Project>> GetProjectsByUserAsync(Guid userId)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task<Project> CreateProjectAsync(Project project)
    //{
    //    throw new NotImplementedException();
    //}

    //public System.Threading.Tasks.Task DeleteProjectAsync(Guid projectId)
    //{
    //    throw new NotImplementedException();
    //}
}

