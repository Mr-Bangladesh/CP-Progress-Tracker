using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CP.Core.Domains
{
    public class User : BaseEntity
    {
        private ICollection<UserGroup> _groups;
        private ICollection<UserOnlineJudge> _onlineJudges;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the username
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the date time of creating the user
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date time of updating the user
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the university
        /// </summary>
        public int UniversityId { get; set; }
        public virtual University University { get; set; }

        /// <summary>
        /// Gets or sets the collection of groups where the user in
        /// </summary>
        public virtual ICollection<UserGroup> JoinedGroups
        {
            get => _groups ?? (_groups = new List<UserGroup>());
            protected set => _groups = value;
        }

        /// <summary>
        /// Gets or sets the collection of online judges where the user has account
        /// </summary>
        public virtual ICollection<UserOnlineJudge> OnlineJudges
        {
            get => _onlineJudges ?? (_onlineJudges = new List<UserOnlineJudge>());
            protected set => _onlineJudges = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        public bool Deleted { get; set; }
    }
}
