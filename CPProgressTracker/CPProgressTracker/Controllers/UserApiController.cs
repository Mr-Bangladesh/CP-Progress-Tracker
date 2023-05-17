using CPProgressTracker.Models;
using CPProgressTracker.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CPProgressTracker.Controllers
{
    [Route("api/user")]
    public class UserApiController : BaseApiController
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]BaseRequestModel<LoginModel> model)
        {
            var response = new GenericResponseModel<LoginResponseModel>();

            if (ModelState.IsValid)
            {
                var responseData = new LoginResponseModel()
                {
                    UserInfo = new UserInfoModel()
                    {
                        FirstName = "Test",
                        LastName = "Test",
                        Email = model.Data.Email
                    },
                    Token = GetToken(model.Data.Email)
                };
                response.Message = "The User is Authenticated";
                response.Data = responseData;
                return Ok(response);
            }

            response.Message = "The User is Authenticated";

            foreach (var modelState in ModelState.Values)
                foreach (var error in modelState.Errors)
                    response.ErrorList.Add(error.ErrorMessage);

            return BadRequest(response);
        }

        [Authorize]
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
        private string GetToken(string userName)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, userName)
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("CPProgressTracker.AuthKey"));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(2),
                signingCredentials: cred
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
        #endregion
    }
}
