using CPProgressTracker.Domains;

namespace CPProgressTracker.Services
{
    public interface IUserService
    {
        Task DeleteUserAsync(User user);
        Task<User> GetUserByIdAsync(int id);
        Task InsertUserAsync(User user);
        Task<IList<User>> SearchUsersAsync(string firstName = "", string lastName = "", string email = "", bool showHidden = false);
        Task UpdateUserAsync(User user);
    }
}