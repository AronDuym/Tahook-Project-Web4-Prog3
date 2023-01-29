using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;

namespace Tahook.Api.Controllers
{
    [ApiController]
#if ProducesConsumes
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
#endif
    [Route("GameTopics")]
    public class GameTopicController : ControllerBase
    {
        private readonly ILogger<GameTopicController> _logger;
        private readonly IGameTopicRepository _gameTopicRepository;

        public GameTopicController(ILogger<GameTopicController> logger, IGameTopicRepository gameTopicRepository)
        {
            _logger = logger;
            _gameTopicRepository = gameTopicRepository;
        }

        [HttpGet(Name = nameof(GameTopicsGetAll))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GameTopic>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<GameTopic>> GameTopicsGetAll()
        {
            _logger?.LogDebug("-> GameTopic::GetAll");
            var gameTopics = _gameTopicRepository.GameTopicsGetAll();
            if (gameTopics == null)
            {
                _logger?.LogDebug("<- GameTopic::GetAll (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- GameTopic::GetAll (Ok");
            return Ok(gameTopics);

        }

        [HttpGet("GetById/{id}", Name = nameof(GameTopicGetById))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GameTopic))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<GameTopic> GameTopicGetById(int id)
        {
            _logger?.LogDebug("-> GameTopic::GetById");
            var gameTopic = _gameTopicRepository.GameTopicGetById(id);
            if (gameTopic == null)
            {
                _logger?.LogDebug("<- GameTopic::GetById (Fail");
                return NotFound();
            }
            _logger?.LogDebug("<- GameTopic::GetById (Ok");
            return Ok(gameTopic);
        }

        [HttpGet("GetByDescription/{description}", Name =nameof(GameTopicGetByDescription))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GameTopic))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<GameTopic> GameTopicGetByDescription(string description)
        {
            _logger?.LogDebug("-> GameTopic::GetByDescription");
            var gameTopic = _gameTopicRepository.GameTopicGetByDescription(description);
            if (gameTopic == null)
            {
                _logger?.LogDebug("<- GameTopic::GetByDescription (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- GameTopic::GetByDescription (Ok)");
            return Ok(gameTopic);
        }

        //------------------------------------------------------------------------------------------------

        [HttpGet("GetAllGameTopicsAsync", Name = nameof(GameTopicsGetAllAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GameTopic>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<GameTopic>>> GameTopicsGetAllAsync()
        {
            _logger?.LogDebug("-> GameTopic::GetAllAsync");
            var gameTopics =  await _gameTopicRepository.GameTopicsGetAllAsync();
            if (gameTopics == null)
            {
                _logger?.LogDebug("<- GameTopic::GetAllAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- GameTopic::GetAllAsync (Ok");
            return Ok(gameTopics);

        }

        [HttpGet("GetByIdAsync/{id}", Name = nameof(GameTopicGetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GameTopic))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async  Task<ActionResult<GameTopic>> GameTopicGetByIdAsync(int id)
        {
            _logger?.LogDebug("-> GameTopic::GetByIdAsync");
            var gameTopic = await _gameTopicRepository.GameTopicGetByIdAsync(id);
            if (gameTopic == null)
            {
                _logger?.LogDebug("<- GameTopic::GetByIdAsync (Fail");
                return NotFound();
            }
            _logger?.LogDebug("<- GameTopic::GetByIdAsync (Ok");
            return Ok(gameTopic);
        }

        [HttpGet("GetByDescriptionAsync/{description}", Name = nameof(GameTopicGetByDescriptionAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GameTopic))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GameTopic>> GameTopicGetByDescriptionAsync(string description)
        {
            _logger?.LogDebug("-> GameTopic::GetByDescriptionAsync");
            var gameTopic = await _gameTopicRepository.GameTopicGetByDescriptionAsync(description);
            if (gameTopic == null)
            {
                _logger?.LogDebug("<- GameTopic::GetByDescriptionAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- GameTopic::GetByDescriptionAsync (Ok)");
            return Ok(gameTopic);
        }

        //------------------------------------------------------------------------------------------------
        [HttpPost]
        public ActionResult CreateGameTopic(GameTopic gameTopic)
        {
            _gameTopicRepository.GameTopicCreate(gameTopic);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateGameTopic(GameTopic gameTopic)
        {
            _gameTopicRepository.GameTopicUpdate(gameTopic);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteGameTopic(GameTopic gameTopic)
        {
            _gameTopicRepository.GameTopicDelete(gameTopic);
            return Ok();
        }

    }
}
