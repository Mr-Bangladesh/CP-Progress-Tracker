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
    /// Represents a group mapping configuration
    /// </summary>
    public class GroupMap : EntityMappingConfiguration<Group>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable(nameof(Group));
            builder.HasKey(group => group.Id);

            builder.Property(group => group.Name).IsRequired();

            base.Configure(builder);
        }

        #endregion
    }
}
