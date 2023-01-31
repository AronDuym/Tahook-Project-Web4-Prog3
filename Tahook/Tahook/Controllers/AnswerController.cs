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
    [Route("Answers")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerRepository _answerRepository;
        private readonly ILogger<AnswerController> _logger;

        public AnswerController(IAnswerRepository answerRepository, ILogger<AnswerController> logger)
        {
            _answerRepository = answerRepository;
            _logger = logger;
        }

        [HttpGet(Name =nameof(AnswersGetAll))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Answer>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Answer>> AnswersGetAll()
        {
            _logger?.LogDebug("-> Answer::GetAll");
            var answers = _answerRepository.AnswersGetAll();
            if (answers == null)
            {
                _logger?.LogDebug("<- Answer::GetAll (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- Answer::GetAll (Ok)");
            return Ok(answers);
        }

        [HttpGet("GetById/{id}", Name = nameof(AnswerGetById))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Answer))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Answer> AnswerGetById(int id)
        {
            _logger?.LogDebug("-> Answer::GetById");
            var answer = _answerRepository.AnswerGetById(id);
            if (answer == null)
            {
                _logger?.LogDebug("<- Answer::GetById (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Answer::GetById (Ok)");
            return Ok(answer);
        }

        [HttpGet("GetByDescription/{description}", Name = nameof(AnswerGetByDescription))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Answer))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Answer> AnswerGetByDescription(string description)
        {
            _logger?.LogDebug("-> Answer::GetByDescription");
            var answer = _answerRepository.AnswerGetByDescription(description);
            if (answer == null)
            {
                _logger?.LogDebug("<- Answer::GetByDescription (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Answer::GetByDescription (Ok)");
            return Ok(answer);

        }

        [HttpGet("GetAnswersByQuestion/{question}", Name = nameof(AnswersGetByQuestion))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Answer>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Answer>> AnswersGetByQuestion(Question question)
        {
            _logger?.LogDebug("-> Answer::GetAnswersByQuestion");
            var answers = _answerRepository.AnswersGetByQuestion(question);
            if (answers == null)
            {
                _logger?.LogDebug("<- Answer::GetAnswersByQuestion (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- Answer::GetAnswersByQuestion (Ok)");
            return Ok(answers);
        }

        //----------------------------------------------------------------------------------------

        [HttpGet("GetAllAnswersAsync", Name = nameof(AnswersGetAllAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Answer>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Answer>>> AnswersGetAllAsync()
        {
            _logger?.LogDebug("-> Answer::GetAllAsync");
            var answers = await _answerRepository.AnswersGetAllAsync();
            if (answers == null)
            {
                _logger?.LogDebug("<- Answer::GetAllAsync (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- Answer::GetAllAsync (Ok)");
            return Ok(answers);
        }

        [HttpGet("GetByIdAsync/{id}", Name = nameof(AnswerGetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Answer))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Answer>> AnswerGetByIdAsync(int id)
        {
            _logger?.LogDebug("-> Answer::GetByIdAsync");
            var answer = await _answerRepository.AnswerGetByIdAsync(id);
            if (answer == null)
            {
                _logger?.LogDebug("<- Answer::GetByIdAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Answer::GetByIdAsync (Ok)");
            return Ok(answer);
        }

        [HttpGet("GetByDescriptionAsync/{description}", Name = nameof(AnswerGetByDescriptionAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Answer))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Answer>> AnswerGetByDescriptionAsync(string description)
        {
            _logger?.LogDebug("-> Answer::GetByDescriptionAsync");
            var answer = await _answerRepository.AnswerGetByDescriptionAsync(description);
            if (answer == null)
            {
                _logger?.LogDebug("<- Answer::GetByDescriptionAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- Answer::GetByDescriptionAsync (Ok)");
            return Ok(answer);

        }

        [HttpGet("GetAnswersByQuestionAsync/{question}", Name = nameof(AnswersGetByQuestionAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Answer>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Answer>>> AnswersGetByQuestionAsync(Question question)
        {
            _logger?.LogDebug("-> Answer::GetAnswersByQuestionAsync");
            var answers = await _answerRepository.AnswersGetByQuestionAsync(question);
            if (answers == null)
            {
                _logger?.LogDebug("<- Answer::GetAnswersByQuestionAsync (Fail)");
                return NotFound(new List<Answer>());
            }
            _logger?.LogDebug("<- Answer::GetAnswersByQuestionAsync (Ok)");
            return Ok(answers);
        }


        //Crud-------------------------------------------------------------------------------------
        [HttpPost]
        public ActionResult CreateAnswer(Answer answer)
        {
            _answerRepository.AnswerCreate(answer);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateAnswer(Answer answer)
        {
            _answerRepository.AnswerUpdate(answer);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteAnswer(Answer answer)
        {
            _answerRepository.AnswerDelete(answer);
            return Ok();
        }


    }
}
