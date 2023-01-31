using Microsoft.EntityFrameworkCore;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TahookContext _dbcontext;

        public UserRepository(TahookContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void UserCreate(User user)
        {
            _dbcontext.User.Add(user);
            _dbcontext.SaveChanges();
        }

        public void UserDelete(User user)
        {
            _dbcontext.User.Remove(user);
            _dbcontext.SaveChanges();
        }

        public User? UserGetByEmail(string email)
        {
            User? user = _dbcontext.User.FirstOrDefault(x => x.Email == email);
            return user;
        }

        public Task<User?> UserGetByEmailAsync(string email)
        {
            return _dbcontext.User.FirstOrDefaultAsync(x => x.Email == email);
        }

        public User? UserGetById(int id)
        {
            User? user = _dbcontext.User.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public Task<User?> UserGetByIdAsync(int id)
        {
            return _dbcontext.User.FirstOrDefaultAsync(x => x.Id == id);
        }

        public User? UserGetByPassword(string password)
        {
            User? user = _dbcontext.User.FirstOrDefault(x => x.Password== password);
            return user;
        }

        public Task<User?> UserGetByPasswordAsync(string password)
        {
            return _dbcontext.User.FirstOrDefaultAsync(x => x.Password == password);
        }

        public List<User?> UserGetByQuiz(Quiz quiz)
        {
            List<User?> users = _dbcontext.User.Where(x => x.Quiz.Id == quiz.Id).ToList();
            return users;
        }

        public Task<List<User?>> UserGetByQuizAsync(Quiz quiz)
        {
            return _dbcontext.User.Where(x => x.Quiz.Id == quiz.Id).ToListAsync();
        }

        public List<User?> UserGetByRole(Role role)
        {
            List<User?> users = _dbcontext.User.Where(x => x.Role.Id == role.Id).ToList();
            return users;
        }

        public Task<List<User?>> UserGetByRoleAsync(Role role)
        {
            return _dbcontext.User.Where(x => x.Role.Id == role.Id).ToListAsync();
        }

        public User? UserGetByUsername(string username)
        {
            User? user = _dbcontext.User.FirstOrDefault(x => x.UserName== username);
            return user;
        }

        public Task<User?> UserGetByUsernameAsync(string username)
        {
            return _dbcontext.User.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public List<User> UsersGetAll()
        {
            List<User> users = _dbcontext.User.ToList();
            return users;

        }

        public Task<List<User>> UsersGetAllAsync()
        {
            return _dbcontext.User.ToListAsync();
        }

        public void UserUpdate(User user)
        {
            _dbcontext.User.Update(user);
            _dbcontext.SaveChanges();
        }
    }
}
