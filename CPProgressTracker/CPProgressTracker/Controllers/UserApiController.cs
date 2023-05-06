using CPProgressTracker.Models;
using CPProgressTracker.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace CPProgressTracker.Controllers
{
    [Route("api/user")]
    public class UserApiController : BaseApiController
    {
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]BaseRequestModel<LoginModel> model)
        {
            if (ModelState.IsValid)
            {
                var response = new GenericResponseModel<LoginResponseModel>()
                {
                    Message = "User is Authenticated"
                };

                var responseData = new LoginResponseModel()
                {
                    UserInfo = new UserInfoModel()
                    {
                        FirstName = "Test",
                        LastName = "Test",
                        Email = model.Data.Email
                    },
                    Token = GetToken()
                };

            }
            
        }

        [Route("get-user-data/{id}")]
        public async Task<IActionResult> GetUserData(int id)
        {
            var response = new GenericResponseModel<string>()
            {
                Data = "This action should be authorized",
                Message = $"Id sent with request is {id}"
            };

            return Ok(response);
        }

        #region Utilities
        private async Task<string> GetToken(string userName)
        {
            
        }
        #endregion
    }
}
