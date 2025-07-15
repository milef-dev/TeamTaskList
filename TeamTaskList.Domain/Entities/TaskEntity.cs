using TeamTaskList.Domain.Enums;
using TaskStatus = TeamTaskList.Domain.Enums.TaskStatus;

namespace TeamTaskList.Domain.Entities
{
    public class TaskEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public TaskPriority Priority { get; private set; }
        public DateTime DueDate { get; private set; }
        public TaskStatus Status { get; private set; }

        public TaskEntity(string title, string description, TaskPriority priority, DateTime dueDate)
        {
            Title = title;
            Description = description;
            Priority = priority;
            DueDate = dueDate;
            Status = TaskStatus.Pendente;
        }
        // ✅ Permite atualizar o status da tarefa
        public void UpdateStatus(TaskStatus newStatus)
        {
            Status = newStatus;
        }

        // ✅ Impede alteração da prioridade após a criação
        public void UpdatePriority(TaskPriority newPriority)
        {
            throw new InvalidOperationException("Prioridade não pode ser alterada após a criação.");
        }
    }
}
