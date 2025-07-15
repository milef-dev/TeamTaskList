using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTaskList.Application.Interfaces;
using Task = TeamTaskList.Domain.Entities.Task;
using TaskStatus = TeamTaskList.Domain.Enums.TaskStatus;

namespace TeamTaskList.Application.Services
{
    public class ReportService : IReportService
    {
        private readonly List<Task> _tasks;

        public ReportService()
        {
            _tasks = new List<Task>();
        }

        public double Report_30D(Guid userId)
        {
            var dataLimite = DateTime.UtcNow.AddDays(-30);

            var taskFinish = _tasks
                .Where(t => t.Status == TaskStatus.Concluida &&
                            t.History.Any(h =>
                                h.UserId == userId &&
                                //h.Alteracao.Contains("Concluída") &&
                                h.ModificationDate >= dataLimite));

            var days = (DateTime.UtcNow - dataLimite).Days;
            return days > 0 ? taskFinish.Count() / (double)days : 0;
        }
    }
}
