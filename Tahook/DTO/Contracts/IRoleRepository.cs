using Tahook.DTO.Model;

namespace Tahook.DTO.Contracts
{
    public interface IRoleRepository
    {
        List<Role> RolesGetAll();
        Task<List<Role>> RolesGetAllAsync();

        Role? RoleGetById(int id);
        Task<Role?> RoleGetByIdAsync(int id);

        void RoleCreate(Role role);
        void RoleUpdate(Role role);
        void RoleDelete(Role role);
    }
}
