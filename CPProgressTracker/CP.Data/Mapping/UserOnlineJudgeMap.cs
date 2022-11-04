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
    /// Represents a user online mapping configuration
    /// </summary>
    public class UserOnlineJudgeMap : EntityMappingConfiguration<UserOnlineJudge>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserOnlineJudge> builder)
        {
            builder.ToTable(nameof(UserOnlineJudge));
            builder.HasKey(uoj => uoj.Id);

            builder.HasOne(uoj => uoj.User)
                .WithMany(u => u.OnlineJudges)
                .HasForeignKey(uoj => uoj.UserId)
                .IsRequired();

            builder.HasOne(uoj => uoj.OnlineJudge)
                .WithMany()
                .HasForeignKey(uoj => uoj.OnlineJudgeId)
                .IsRequired();

            base.Configure(builder);
        }

        #endregion
    }
}
