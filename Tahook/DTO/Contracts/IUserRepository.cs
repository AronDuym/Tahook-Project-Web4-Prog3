using Tahook.DTO.Model;

namespace Tahook.DTO.Contracts
{
    public interface IUserRepository
    {
        List<User> UsersGetAll();

        Task<List<User>> UsersGetAllAsync();

        User? UserGetById(int id);
        User? UserGetByUsername(string username);
        User? UserGetByEmail(string email);
        User? UserGetByPassword(string password);

        Task<User?> UserGetByIdAsync(int id);
        Task<User?> UserGetByUsernameAsync(string username);
        Task<User?> UserGetByEmailAsync(string email);
        Task<User?> UserGetByPasswordAsync(string password);

        void UserCreate(User user);
        void UserUpdate(User user);
        void UserDelete(User user);
    }
}
