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
    /// Represents a user mapping configuration
    /// </summary>
    public class UserMap : EntityMappingConfiguration<User>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(user => user.Id);

            builder.Property(user => user.Name).IsRequired();
            builder.Property(user => user.UserName).IsRequired();
            builder.Property(user => user.Email).IsRequired();

            base.Configure(builder);
        }

        #endregion
    }
}
