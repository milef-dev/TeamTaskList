using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Domain.Enums;

namespace TeamTaskList.Domain.Entities
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public Enums.TaskStatus Status { get; set; } = Enums.TaskStatus.Pendente;
        public TaskPriority Priority { get; private set; }

        public Guid ProjectId { get; set; }

        public List<TaskComment> Comments { get; set; } = new List<TaskComment>();
        public List<TaskHistory> History { get; set; } = new List<TaskHistory>();

        public Task(TaskPriority priority)
        {
            Priority = priority;
        }

        //public void UpdateStatus(TaskStatus novoStatus)
        //{
        //    Status = novoStatus;
        //}

        //public void AddComments(string comentario, Guid userId)
        //{
        //    Comments.Add(new TaskComment
        //    {
        //        Id = Guid.NewGuid(),
        //        Conteudo = comentario,
        //        Data = DateTime.UtcNow,
        //        UsuarioId = userId
        //    });

        //    History.Add(new TaskHistory
        //    {
        //        Id = Guid.NewGuid(),
        //        Alteracao = $"Comentário adicionado: {comentario}",
        //        Data = DateTime.UtcNow,
        //        UsuarioId = userId
        //    });
        //}

    }
}
