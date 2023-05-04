using CPProgressTracker.Models;
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
            if (model.Data.Password == "admin")
            {
                var response = new GenericResponseModel<string>()
                {
                    Data = "Login Credentials Correct",
                    Message = model.Data.Email
                };
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
