using Blazor_Login_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Login_System.Services
{
    public class UserService
    {
        private readonly MySqlDbContext _context;
        public UserService(MySqlDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task<User> LogIn(User user)
        {
            try
            {
                return await _context.Users.FirstAsync(
                    u => u.userName == user.userName && u.password == user.password);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
