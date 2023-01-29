using Microsoft.AspNetCore.Mvc;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;

namespace Tahook.Api.Controllers
{
    [ApiController]
#if ProducesConsumes
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
#endif
    [Route("Quizzes")]
    public class QuizController : ControllerBase
    {
        private readonly ILogger<QuizController> _logger;
        private readonly IQuizRepository _quizRepository;

        public QuizController(ILogger<QuizController> logger, IQuizRepository quizRepository)
        {
            _logger = logger;
            _quizRepository = quizRepository;
        }

        [HttpGet(Name = nameof(QuizzesGetAll))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Quiz>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Quiz>> QuizzesGetAll() 
        {
            _logger?.LogDebug("-> Quiz::GetAll");
            var quizzes = _quizRepository.QuizzesGetAll();
            if (quizzes == null)
            {
                _logger?.LogDebug("<- Quiz::GetAll (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Quiz::GetAll (Ok)");
            return Ok(quizzes);
        }

        [HttpGet("GetById/{id}", Name = nameof(QuizGetById))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Quiz))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Quiz> QuizGetById(int id)
        {
            _logger?.LogDebug("-> Quiz::QuizGetById");
            var quiz = _quizRepository.QuizGetById(id);
            if (quiz == null)
            {
                _logger?.LogDebug("<- Quiz::QuizGetById (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Quiz::QuizGetById (Ok)");
            return Ok(quiz);
        }


        [HttpGet("QuizzesGetByGameTopic/{GameTopic}", Name = nameof(QuizzesGetByGameTopic))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Quiz>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Quiz>> QuizzesGetByGameTopic(GameTopic gameTopic)
        {
            _logger?.LogDebug("-> Quiz::QuizzesGetByGameTopic");
            var quizzes = _quizRepository.QuizGetGuizzesByGameTopic(gameTopic);
            if (quizzes == null)
            {
                _logger?.LogDebug("<- Quiz::QuizzesGetByGameTopic (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Quiz::QuizzesGetByGameTopic (Ok)");
            return Ok(quizzes);
        }


        //---------------------------------------------------------------------------------------

        [HttpGet("GetAllQuizzesAsync", Name = nameof(QuizzesGetAllAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Quiz>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Quiz>>> QuizzesGetAllAsync()
        {
            _logger?.LogDebug("-> Quiz::GetAllQuizzesAsync");
            var quizzes = await _quizRepository.QuizzesGetAllAsync();
            if (quizzes == null)
            {
                _logger?.LogDebug("<- Quiz::GetAllQuizzesAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Quiz::GetAllQuizzesAsync (Ok)");
            return Ok(quizzes);
        }

        [HttpGet("GetByIdAsync/{id}", Name = nameof(QuizGetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Quiz))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Quiz>> QuizGetByIdAsync(int id)
        {
            _logger?.LogDebug("-> Quiz::GetByIdAsync");
            var quiz = await _quizRepository.QuizGetByIdAsync(id);
            if (quiz == null)
            {
                _logger?.LogDebug("<- Quiz::GetByIdAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Quiz::GetByIdAsync (Ok)");
            return Ok(quiz);
        }


        [HttpGet("QuizzesGetByGameTopicAsync/{GameTopic}", Name = nameof(QuizzesGetByGameTopicAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Quiz>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Quiz>>> QuizzesGetByGameTopicAsync(GameTopic gameTopic)
        {
            _logger?.LogDebug("-> Quiz::QuizzesGetByGameTopicAsync");
            var quizzes = await _quizRepository.QuizGetGuizzesByGameTopicAsync(gameTopic);
            if (quizzes == null)
            {
                _logger?.LogDebug("<- Quiz::QuizzesGetByGameTopicAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Quiz::QuizzesGetByGameTopicAsync (Ok)");
            return Ok(quizzes);
        }


        //---------------------------------------------------------------------------------------
        [HttpPost]
        public ActionResult CreateQuiz(Quiz quiz)
        {
            _quizRepository.QuizCreate(quiz);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateQuiz(Quiz quiz)
        {
            _quizRepository.QuizUpdate(quiz);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteQuiz(Quiz quiz)
        {
            _quizRepository.QuizDelete(quiz);
            return Ok();
        }
    }
}
