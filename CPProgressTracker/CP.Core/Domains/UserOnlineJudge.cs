using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Core.Domains
{
    public class UserOnlineJudge : BaseEntity
    {
        /// <summary>
        /// Gets or sets the user identifier
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the Online Judge identifier
        /// </summary>
        public int OnlineJudgeId { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets the category
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual OnlineJudge OnlineJudge { get; set; }
    }
}
