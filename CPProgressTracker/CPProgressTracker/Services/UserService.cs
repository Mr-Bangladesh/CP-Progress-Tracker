using CPProgressTracker.Data;
using CPProgressTracker.Domains;
using Microsoft.EntityFrameworkCore;

namespace CPProgressTracker.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<User>> SearchUsersAsync(string firstName = "",
            string lastName = "",
            string email = "",
            bool showHidden = false)
        {
            var users = _dbContext.Users.AsQueryable();

            if (!string.IsNullOrEmpty(firstName))
                users = users.Where(x => x.FirstName.Contains(firstName));

            if (!string.IsNullOrEmpty(lastName))
                users = users.Where(x => x.LastName.Contains(lastName));

            if (!string.IsNullOrEmpty(email))
                users = users.Where(x => x.Email.Contains(email));

            if (!showHidden)
                users = users.Where(x => !x.Deleted);

            return await users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var users = _dbContext.Users.AsQueryable();

            return await users.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task InsertUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
