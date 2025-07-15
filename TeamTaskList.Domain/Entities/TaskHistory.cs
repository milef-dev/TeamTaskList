using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTaskList.Domain.Entities
{
    public class TaskHistory
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public string ModifiedField { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime ModificationDate { get; set; }
        public Guid UserId { get; set; }

    }
}
