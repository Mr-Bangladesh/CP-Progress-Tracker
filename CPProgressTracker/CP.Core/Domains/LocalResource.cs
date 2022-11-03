using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Core.Domains
{
    public class LocalResource : BaseEntity
    {
        /// <summary>
        /// Gets or sets the string resource key
        /// </summary>
        public string ResourceKey { get; set; }

        /// <summary>
        /// Gets or sets the string resource value
        /// </summary>
        public string ResourceValue { get; set; }
    }
}
