using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Domain.Entities;

namespace TeamTaskList.Application.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetProjectsByUserIdAsync(int userId);

    }

}
