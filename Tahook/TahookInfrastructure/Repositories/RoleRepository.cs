using Microsoft.EntityFrameworkCore;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly TahookContext _dbcontext;

        public RoleRepository(TahookContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void RoleCreate(Role role)
        {
            _dbcontext.Role.Add(role);
            _dbcontext.SaveChanges();
        }

        public void RoleDelete(Role role)
        {
            _dbcontext.Role.Remove(role);
        }

        public Role? RoleGetById(int id)
        {
            Role? role = _dbcontext.Role.FirstOrDefault(x => x.Id == id);
            return role;
        }

        public Task<Role?> RoleGetByIdAsync(int id)
        {
            return _dbcontext.Role.FirstOrDefaultAsync(x => x.Id == id);    
        }

        public List<Role> RolesGetAll()
        {
            List<Role> roles = _dbcontext.Role.ToList();
            return roles;
        }

        public Task<List<Role>> RolesGetAllAsync()
        {
            return _dbcontext.Role.ToListAsync();
        }

        public void RoleUpdate(Role role)
        {
            _dbcontext.Role.Update(role);
        }
    }
}
