using CP.Core.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Data.Mapping
{
    /// <summary>
    /// Represents a schedule task mapping configuration
    /// </summary>
    public class ScheduleTaskMap : EntityMappingConfiguration<ScheduleTask>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<ScheduleTask> builder)
    {
        builder.ToTable(nameof(ScheduleTask));
        builder.HasKey(scheduleTask => scheduleTask.Id);

        builder.Property(scheduleTask => scheduleTask.Name).IsRequired();
        builder.Property(scheduleTask => scheduleTask.Seconds).IsRequired();
        builder.Property(scheduleTask => scheduleTask.Type).IsRequired();

        base.Configure(builder);
    }

    #endregion
}
}
