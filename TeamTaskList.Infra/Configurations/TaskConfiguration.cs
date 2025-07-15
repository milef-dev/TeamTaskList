using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = TeamTaskList.Domain.Entities.Task;

namespace TeamTaskList.Infra.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Tasks");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Description).HasMaxLength(500);
            builder.Property(t => t.Priority).IsRequired();
            builder.Property(t => t.Status).IsRequired();
            builder.Property(t => t.DueDate).IsRequired();

            builder.HasMany(t => t.History)
                   .WithOne()
                   .HasForeignKey(h => h.TaskId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
