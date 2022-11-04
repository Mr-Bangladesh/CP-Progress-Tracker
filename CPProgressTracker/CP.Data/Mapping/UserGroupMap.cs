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
    /// Represents a user group mapping configuration
    /// </summary>
    public class UserGroupMap : EntityMappingConfiguration<UserGroup>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserGroup> builder)
        {
            builder.ToTable(nameof(UserGroup));
            builder.HasKey(ug => ug.Id);

            builder.HasOne(ug => ug.User)
                .WithMany(g => g.JoinedGroups)
                .HasForeignKey(ug => ug.UserId)
                .IsRequired();

            builder.HasOne(ug => ug.Group)
                .WithMany()
                .HasForeignKey(ug => ug.GroupId)
                .IsRequired();

            base.Configure(builder);
        }

        #endregion
    }
}
