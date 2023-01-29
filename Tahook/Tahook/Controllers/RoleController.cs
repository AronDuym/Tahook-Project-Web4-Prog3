using Microsoft.AspNetCore.Mvc;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;
using Tahook.Infrastructure.Repositories;

namespace Tahook.Api.Controllers
{
    [ApiController]
#if ProducesConsumes
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
#endif
    [Route("Roles")]
    public class RoleController : ControllerBase
    {
        private readonly ILogger<RoleController> _logger;
        private readonly IRoleRepository _roleRepository;

        public RoleController(ILogger<RoleController> logger, IRoleRepository roleRepository)
        {
            _logger = logger;
            _roleRepository = roleRepository;
        }

        [HttpGet(Name = nameof(RolesGetAll))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Role>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Role>> RolesGetAll()
        {
            _logger?.LogDebug("-> Role::GetAll");
            var roles = _roleRepository.RolesGetAll();
            if (roles == null)
            {
                _logger?.LogDebug("<- Role::GetAll (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- Role::GetAll (Ok)");
            return Ok(roles);
        }

        [HttpGet("GetById", Name =nameof(RoleGetById))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Role))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Role> RoleGetById(int id)
        {
            _logger?.LogDebug("-> Role::GetById");
            var role = _roleRepository.RoleGetById(id);
            if (role == null)
            {
                _logger?.LogDebug("<- Role::GetById (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Role::GetById (Ok)");
            return Ok(role);
        }

        //------------------------------------------------------------------------------------------------

        [HttpGet("GetAllRolesAsync", Name = nameof(RolesGetAllAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Role>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Role>>> RolesGetAllAsync()
        {
            _logger?.LogDebug("-> Role::GetAllRolesAsync");
            var roles = await _roleRepository.RolesGetAllAsync();
            if (roles == null)
            {
                _logger?.LogDebug("<- Role::GetAllRolesAsync (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- Role::GetAllRolesAsync (Ok)");
            return Ok(roles);
        }

        [HttpGet("GetByIdAsync", Name = nameof(RoleGetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Role))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Role>> RoleGetByIdAsync(int id)
        {
            _logger?.LogDebug("-> Role::GetByIdAsync");
            var role = await _roleRepository.RoleGetByIdAsync(id);
            if (role == null)
            {
                _logger?.LogDebug("<- Role::GetByIdAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Role::GetByIdAsync (Ok)");
            return Ok(role);
        }

        //------------------------------------------------------------------------------------------------

        [HttpPost]
        public ActionResult<Role> CreateRole(Role role)
        {
            _roleRepository.RoleCreate(role);
            return Ok();
        }

        [HttpPut]
        public ActionResult<Role> UpdateRole(Role role)
        {
            _roleRepository.RoleUpdate(role);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteRole(Role role)
        {
            _roleRepository.RoleDelete(role);
            return Ok();
        }
    }
}
