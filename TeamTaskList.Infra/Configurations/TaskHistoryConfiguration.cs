using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamTaskList.Domain.Entities;

namespace TeamTaskList.Infra.Configurations
{
    public class TaskHistoryConfiguration : IEntityTypeConfiguration<TaskHistory>
    {
        public void Configure(EntityTypeBuilder<TaskHistory> builder)
        {
            builder.ToTable("Historys");
            builder.HasKey(h => h.Id);

            builder.Property(h => h.ModifiedField).IsRequired().HasMaxLength(200);
            builder.Property(h => h.ModificationDate).IsRequired();
            builder.Property(h => h.UserId).IsRequired();
        }
    }
}
