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
    /// Represents a online judge mapping configuration
    /// </summary>
    public class OnlineJudgeMap : EntityMappingConfiguration<OnlineJudge>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<OnlineJudge> builder)
        {
            builder.ToTable(nameof(OnlineJudge));
            builder.HasKey(oj => oj.Id);

            builder.Property(oj => oj.Name).IsRequired();
            builder.Property(oj => oj.Url).IsRequired();

            base.Configure(builder);
        }

        #endregion
    }
}
