using CPProgressTracker.Models.User;

namespace CPProgressTracker.Models
{
    public class LoginResponseModel
    {
        public LoginResponseModel()
        {
            UserInfo = new();
        }
        public UserInfoModel UserInfo { get; set; }
        public string Token { get; set; }
    }
}
