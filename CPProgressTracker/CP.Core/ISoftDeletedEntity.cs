using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Core
{
    public interface ISoftDeletedEntity
    {
        public bool Deleted { get; set; }
    }
}
