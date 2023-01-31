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
        List<User?> UserGetByRole(Role role);
        List<User?> UserGetByQuiz(Quiz quiz);

        Task<User?> UserGetByIdAsync(int id);
        Task<User?> UserGetByUsernameAsync(string username);
        Task<User?> UserGetByEmailAsync(string email);
        Task<User?> UserGetByPasswordAsync(string password);
        Task<List<User?>> UserGetByQuizAsync(Quiz quiz);
        Task<List<User?>> UserGetByRoleAsync(Role role);

        void UserCreate(User user);
        void UserUpdate(User user);
        void UserDelete(User user);
    }
}
