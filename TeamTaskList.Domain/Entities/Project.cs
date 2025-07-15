using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TeamTaskList.Domain.Entities
{
    public class Project
    {
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] // ignora se não enviado
        public Guid Id { get; set; } = Guid.NewGuid(); 
        public string Nome { get; set; } = string.Empty;
        public Guid UserId { get; set; }

        [JsonIgnore]
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}
