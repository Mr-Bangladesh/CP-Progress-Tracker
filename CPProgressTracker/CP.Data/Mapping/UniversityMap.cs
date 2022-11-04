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
    /// Represents a university mapping configuration
    /// </summary>
    public class UniversityMap : EntityMappingConfiguration<University>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<University> builder)
        {
            builder.ToTable(nameof(University));
            builder.HasKey(university => university.Id);

            builder.Property(university => university.Name).IsRequired();
            builder.Property(university => university.Url).IsRequired();

            base.Configure(builder);
        }

        #endregion
    }
}
