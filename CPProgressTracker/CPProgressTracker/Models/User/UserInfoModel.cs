using System.ComponentModel.DataAnnotations;

namespace CPProgressTracker.Models.User
{
    public class UserInfoModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
