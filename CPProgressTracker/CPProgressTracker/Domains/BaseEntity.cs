using System.ComponentModel.DataAnnotations;

namespace CPProgressTracker.Domains
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
