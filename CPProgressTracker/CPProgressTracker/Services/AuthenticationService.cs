using CPProgressTracker.Domains;
using Microsoft.AspNetCore.Authentication;

namespace CPProgressTracker.Services
{
    public class AuthenticationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthenticationService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task LoginAsync(User user)
        {
            await _httpContextAccessor.HttpContext.SignInAsync();
        }

        public async Task SignupAsync()
        {

        }
    }
}
