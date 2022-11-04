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
    /// Represents local resources mapping configuration
    /// </summary>
    public class LocalResourceMap : EntityMappingConfiguration<LocalResource>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<LocalResource> builder)
        {
            builder.ToTable(nameof(LocalResource));
            builder.HasKey(localResource => localResource.Id);

            base.Configure(builder);
        }

        #endregion
    }
}
