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
    [Route("Users")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _userRepository;

        public UserController(ILogger<UserController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpGet(Name = nameof(UsersGetAll))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<User>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<User>> UsersGetAll()
        {
            _logger?.LogDebug("-> User::GetAll");
            var users = _userRepository.UsersGetAll();
            if (users == null)
            {
                _logger?.LogDebug("<- User::GetAll (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- User::GetAll (Ok)");
            return Ok(users);
        }

        [HttpGet("GetById", Name = nameof(UserGetById))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<User> UserGetById(int id)
        {
            _logger?.LogDebug("-> User::GetById");
            var user = _userRepository.UserGetById(id);
            if (user == null)
            {
                _logger?.LogDebug("<- User::GetById (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- User::GetById (Ok)");
            return Ok(user);
        }

        [HttpGet("GetByUsername", Name = nameof(UserGetByUsername))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<User> UserGetByUsername(string username)
        {
            _logger?.LogDebug("-> User::GetByUsername");
            var user = _userRepository.UserGetByUsername(username);
            if (user == null)
            {
                _logger?.LogDebug("<- User::GetByUsername (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- User::GetByUsername (Ok)");
            return Ok(user);
        }

        [HttpGet("GetByEmail", Name = nameof(UserGetByEmail))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<User> UserGetByEmail(string email)
        {
            _logger?.LogDebug("-> User::GetByEmail");
            var user = _userRepository.UserGetByEmail(email);
            if (user == null)
            {
                _logger?.LogDebug("<- User::GetByEmail (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- User::GetByEmail (Ok)");
            return Ok(user);
        }

        [HttpGet("GetByPassword", Name = nameof(UserGetByPassword))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<User> UserGetByPassword(string password)
        {
            _logger?.LogDebug("-> User::GetByPassword");
            var user = _userRepository.UserGetByPassword(password);
            if (user == null)
            {
                _logger?.LogDebug("<- User::GetByPassword (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- User::GetByPassword (Ok)");
            return Ok(user);
        }

        [HttpGet("GetUsersByRole", Name = nameof(UsersGetByRole))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<User>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<User>> UsersGetByRole(Role role)
        {
            _logger?.LogDebug("-> User::GetUsersByRole");
            var users = _userRepository.UserGetByRole(role);
            if (users == null)
            {
                _logger?.LogDebug("<- User::GetUsersByRole (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- User::GetUsersByRole (Ok)");
            return Ok(users);
        }

        [HttpGet("GetUsersByQuiz", Name = nameof(UsersGetByQuiz))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<User>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<User>> UsersGetByQuiz(Quiz quiz)
        {
            _logger?.LogDebug("-> User::GetUsersByQuiz");
            var users = _userRepository.UserGetByQuiz(quiz);
            if (users == null)
            {
                _logger?.LogDebug("<- User::GetUsersByQuiz (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- User::GetUsersByQuiz (Ok)");
            return Ok(users);
        }

        //------------------------------------------------------------------------------------------------

        [HttpGet("GetAllUsersAsync" , Name = nameof(UsersGetAllAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<User>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<User>>> UsersGetAllAsync()
        {
            _logger?.LogDebug("-> User::GetAllUsersAsync");
            var users = await _userRepository.UsersGetAllAsync();
            if (users == null)
            {
                _logger?.LogDebug("<- User::GetAllUsersAsync (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- User::GetAllUsersAsync (Ok)");
            return Ok(users);
        }

        [HttpGet("GetByIdAsync", Name = nameof(UserGetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<User>> UserGetByIdAsync(int id)
        {
            _logger?.LogDebug("-> User::GetByIdAsync");
            var user = await _userRepository.UserGetByIdAsync(id);
            if (user == null)
            {
                _logger?.LogDebug("<- User::GetByIdAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- User::GetByIdAsync (Ok)");
            return Ok(user);
        }

        [HttpGet("GetByUsernameAsync", Name = nameof(UserGetByUsernameAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<User>> UserGetByUsernameAsync(string username)
        {
            _logger?.LogDebug("-> User::GetByUsernameAsync");
            var user = await _userRepository.UserGetByUsernameAsync(username);
            if (user == null)
            {
                _logger?.LogDebug("<- User::GetByUsernameAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- User::GetByUsernameAsync (Ok)");
            return Ok(user);
        }

        [HttpGet("GetByEmailAsync", Name = nameof(UserGetByEmailAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<User>> UserGetByEmailAsync(string email)
        {
            _logger?.LogDebug("-> User::GetByEmailAsync");
            var user = await _userRepository.UserGetByEmailAsync(email);
            if (user == null)
            {
                _logger?.LogDebug("<- User::GetByEmailAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- User::GetByEmailAsync (Ok)");
            return Ok(user);
        }

        [HttpGet("GetByPasswordAsync", Name = nameof(UserGetByPasswordAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<User>> UserGetByPasswordAsync(string password)
        {
            _logger?.LogDebug("-> User::GetByPasswordAsync");
            var user = await _userRepository.UserGetByPasswordAsync(password);
            if (user == null)
            {
                _logger?.LogDebug("<- User::GetByPasswordAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- User::GetByPasswordAsync (Ok)");
            return Ok(user);
        }

        [HttpGet("GetUsersByRoleAsync", Name = nameof(UsersGetByRoleAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<User>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<User>>> UsersGetByRoleAsync(Role role)
        {
            _logger?.LogDebug("-> User::GetUsersByRoleAsync");
            var users = await _userRepository.UserGetByRoleAsync(role);
            if (users == null)
            {
                _logger?.LogDebug("<- User::GetUsersByRoleAsync (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- User::GetUsersByRoleAsync (Ok)");
            return Ok(users);
        }

        [HttpGet("GetUsersByQuizAsync", Name = nameof(UsersGetByQuizAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<User>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<User>>> UsersGetByQuizAsync(Quiz quiz)
        {
            _logger?.LogDebug("-> User::GetUsersByQuizAsync");
            var users = await _userRepository.UserGetByQuizAsync(quiz);
            if (users == null)
            {
                _logger?.LogDebug("<- User::GetUsersByQuizAsync (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- User::GetUsersByQuizAsync (Ok)");
            return Ok(users);
        }

        //------------------------------------------------------------------------------------------------

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            _userRepository.UserCreate(user);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateUser(User user)
        {
            _userRepository.UserUpdate(user);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteUser(User user) 
        {
            _userRepository.UserDelete(user);
            return Ok();
        }
    }
}
