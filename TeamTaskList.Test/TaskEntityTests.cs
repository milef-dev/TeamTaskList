using System.Runtime.Intrinsics.X86;
using FluentAssertions;
using TeamTaskList.Domain.Entities;
using TeamTaskList.Domain.Enums;
using Xunit;

namespace TeamTaskList.Test.Domain
{
    public class TaskEntityTests
    {
        // Testa se uma nova tarefa é criada com status padrão "Pendente"

        [Fact]
        public void NewTask_Should_Have_Pending_Status()
        {
            // Arrange: Cria uma nova tarefa
            var task = new TaskEntity("Estudar C#", "Descrição", TeamTaskList.Domain.Enums.TaskPriority.Alta, DateTime.Now.AddDays(3));

            // Assert: Verifica se o status inicial é "Pendente"
            task.Status.Should().Be(TeamTaskList.Domain.Enums.TaskStatus.Pendente);
        }

        // Testa se todas as propriedades da tarefa são setadas corretamente na criação

        [Fact]
        public void NewTask_Should_Set_All_Properties_Correctly()
        {
            // Arrange: Define uma data de vencimento futura
            var dueDate = DateTime.Now.AddDays(7);

            // Act: Cria uma nova tarefa com os dados esperados
            var task = new TaskEntity("Fazer backup", "Backup semanal", TeamTaskList.Domain.Enums.TaskPriority.Media, dueDate);

            // Assert: Verifica se todas as propriedades foram atribuídas corretamente
            task.Title.Should().Be("Fazer backup");
            task.Description.Should().Be("Backup semanal");
            task.Priority.Should().Be(TeamTaskList.Domain.Enums.TaskPriority.Media);
            task.DueDate.Should().Be(dueDate);
        }

        // Testa se é possível atualizar o status de uma tarefa

        [Fact]
        public void Updating_Status_Should_Change_Status()
        {
            // Arrange: Cria uma nova tarefa
            var task = new TaskEntity("Testar status", "Descrição", TeamTaskList.Domain.Enums.TaskPriority.Baixa, DateTime.Now.AddDays(2));

            // Act: Atualiza o status da tarefa para "EmAndamento"
            task.UpdateStatus(TeamTaskList.Domain.Enums.TaskStatus.EmAndamento);

            // Assert: Verifica se o status foi atualizado corretamente
            task.Status.Should().Be(TeamTaskList.Domain.Enums.TaskStatus.EmAndamento);
        }

        // Testa se uma exceção é lançada ao tentar alterar a prioridade de uma tarefa

        [Fact]
        public void Updating_Priority_Should_Not_Be_Allowed()
        {
            // Arrange: Cria uma nova tarefa com prioridade "Alta"
            var task = new TaskEntity("Tarefa", "Descrição", TeamTaskList.Domain.Enums.TaskPriority.Alta, DateTime.Now.AddDays(3));

            // Act: Tenta alterar a prioridade para "Baixa"
            Action act = () => task.UpdatePriority(TeamTaskList.Domain.Enums.TaskPriority.Baixa);

            // Assert: Espera que uma exceção de operação inválida seja lançada
            act.Should().Throw<InvalidOperationException>()
               .WithMessage("Prioridade não pode ser alterada após a criação.");
        }
    }
}
