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
    [Route("Questions")]
    public class QuestionController : ControllerBase
    {
        private readonly ILogger<QuestionController> _logger;
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(ILogger<QuestionController> logger, IQuestionRepository questionRepository)
        {
            _logger = logger;
            _questionRepository = questionRepository;
        }

        [HttpGet(Name = nameof(QuestionsGetAll))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Question>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Question>> QuestionsGetAll()
        {
            _logger?.LogDebug("-> Question::GetAll");
            var questions = _questionRepository.QuestionsGetAll();
            if (questions == null)
            {
                _logger?.LogDebug("<- Question::GetAll (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Question::GetAll (Ok)");
            return Ok(questions);
        }

        [HttpGet("GetById/{id}", Name = nameof(QuestionGetById))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Question))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Question> QuestionGetById(int id)
        {
            _logger?.LogDebug("-> Question::GetById");
            var question = _questionRepository.QuestionGetById(id);
            if (question == null)
            {
                _logger?.LogDebug("<- Question::GetById (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Question::GetById (Ok)");
            return Ok(question);
        }

        [HttpGet("GetByDescription/{description}", Name = nameof(QuestionGetByDescription))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Question))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Question> QuestionGetByDescription(string description)
        {
            _logger?.LogDebug("-> Question::GetByDescription");
            var question = _questionRepository.QuestionGetByDescription(description);
            if (question == null)
            {
                _logger?.LogDebug("<- Question::GetByDescription (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Question::GetByDescription (Ok)");
            return Ok(question);
        }

        [HttpGet("GetQuestionsByQuiz/{quiz}", Name = nameof(QuestionsGetByQuiz))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Question>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Question> QuestionsGetByQuiz(Quiz quiz)
        {
            _logger?.LogDebug("-> Question::GetQuestionsByQuiz");
            var questions = _questionRepository.QuestionsGetByQuiz(quiz);
            if (questions == null)
            {
                _logger?.LogDebug("<- Question::GetQuestionsByQuiz (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Question::GetQuestionsByQuiz (Ok)");
            return Ok(questions);
        }



        //-----------------------------------------------------------------------------------------------

        [HttpGet("GetAllQuestionsAsync",Name = nameof(QuestionsGetAllAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Question>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Question>>> QuestionsGetAllAsync()
        {
            _logger?.LogDebug("-> Question::GetAllAsync");
            var questions =  await _questionRepository.QuestionsGetAllAsync();
            if (questions == null)
            {
                _logger?.LogDebug("<- Question::GetAllAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Question::GetAllAsync (Ok)");
            return Ok(questions);
        }

        [HttpGet("GetByIdAsync/{id}", Name = nameof(QuestionGetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Question))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async  Task<ActionResult<Question>> QuestionGetByIdAsync(int id)
        {
            _logger?.LogDebug("-> Question::GetByIdAsync");
            var question = await _questionRepository.QuestionGetByIdAsync(id);
            if (question == null)
            {
                _logger?.LogDebug("<- Question::GetByIdAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Question::GetByIdAsync (Ok)");
            return Ok(question);
        }

        [HttpGet("GetByDescriptionAsync/{description}", Name = nameof(QuestionGetByDescriptionAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Question))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Question>> QuestionGetByDescriptionAsync(string description)
        {
            _logger?.LogDebug("-> Question::GetByDescriptionAsync");
            var question = await _questionRepository.QuestionGetByDescriptionAsync(description);
            if (question == null)
            {
                _logger?.LogDebug("<- Question::GetByDescriptionAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Question::GetByDescriptionAsync (Ok)");
            return Ok(question);
        }

        [HttpGet("GetQuestionsByQuizAsync/{quiz}", Name = nameof(QuestionsGetByQuizAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Question>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Question>> QuestionsGetByQuizAsync(Quiz quiz)
        {
            _logger?.LogDebug("-> Question::GetQuestionsByQuizAsync");
            var questions = _questionRepository.QuestionsGetByQuiz(quiz);
            if (questions == null)
            {
                _logger?.LogDebug("<- Question::GetQuestionsByQuizAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Question::GetQuestionsByQuizAsync (Ok)");
            return Ok(questions);
        }


        //-----------------------------------------------------------------------------------------------

        [HttpPost]
        public ActionResult CreateQuestion(Question question)
        {
            _questionRepository.QuestionCreate(question);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateQuestion(Question question)
        {
            _questionRepository.QuestionUpdate(question);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteQuestion(Question question)
        {
            _questionRepository.QuestionDelete(question);
            return Ok();
        }


    }
}
