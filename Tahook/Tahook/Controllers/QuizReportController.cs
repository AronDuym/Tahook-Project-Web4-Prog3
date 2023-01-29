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
    [Route("QuizReports")]
    public class QuizReportController : ControllerBase
    {
        private readonly ILogger<QuizReportController> _logger;
        private readonly IQuizReportRepository _quizReportRepository;

        public QuizReportController(ILogger<QuizReportController> logger, IQuizReportRepository quizReportRepository)
        {
            _logger = logger;
            _quizReportRepository = quizReportRepository;
        }

        [HttpGet(Name = nameof(QuizReportGetAll))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<QuizReport>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<QuizReport>> QuizReportGetAll()
        {
            _logger?.LogDebug("-> QuizReport::GetAll");
            var quizReports = _quizReportRepository.QuizReportsGetAll();
            if (quizReports == null)
            {
                _logger?.LogDebug("<- QuizReport::GetAll (Fail)");
                return NotFound(new List<QuizReport>());
            }
            _logger?.LogDebug("<- QuizReport:GetAll (Ok)");
            return Ok(quizReports);
        }

        [HttpGet("GetById", Name =nameof(QuizReportGetById))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(QuizReport))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<QuizReport> QuizReportGetById(int id)
        {
            _logger?.LogDebug("-> QuizReport::GetById");
            var quizReport = _quizReportRepository.QuizReportGetById(id);
            if (quizReport == null)
            {
                _logger?.LogDebug("<- QuizReport::GetById (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- QuizReport:GetById (Ok)");
            return Ok(quizReport);
        }

        [HttpGet("GetQuizReportsByQuestion", Name = nameof(QuizReportsGetByQuestion))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<QuizReport>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<QuizReport>> QuizReportsGetByQuestion(Question question)
        {
            _logger?.LogDebug("-> QuizReport::GetQuizReportsbyQuestion");
            var quizReports = _quizReportRepository.QuizReportGetByQuestion(question);
            if (quizReports == null)
            {
                _logger?.LogDebug("<- QuizReport::GetQuizReportsbyQuestion (Fail)");
                return NotFound(new List<QuizReport>());
            }
            _logger?.LogDebug("<- QuizReport:GetQuizReportsbyQuestion (Ok)");
            return Ok(quizReports);
        }

        [HttpGet("GetQuizReportsByAnswer", Name = nameof(QuizReportsGetByAnswer))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<QuizReport>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<QuizReport>> QuizReportsGetByAnswer(Answer answer)
        {
            _logger?.LogDebug("-> QuizReport::GetQuizReportsByAnswer");
            var quizReports = _quizReportRepository.QuizReportGetByAnswer(answer);
            if (quizReports == null)
            {
                _logger?.LogDebug("<- QuizReport::GetQuizReportsByAnswer (Fail)");
                return NotFound(new List<QuizReport>());
            }
            _logger?.LogDebug("<- QuizReport:GetQuizReportsByAnswer (Ok)");
            return Ok(quizReports);
        }

        [HttpGet("GetQuizReportsbyUser", Name = nameof(QuizReportsGetByUser))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<QuizReport>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<QuizReport>> QuizReportsGetByUser(User user)
        {
            _logger?.LogDebug("-> QuizReport::GetQuizReportsbyUser");
            var quizReports = _quizReportRepository.QuizReportGetByUser(user);
            if (quizReports == null)
            {
                _logger?.LogDebug("<- QuizReport::GetQuizReportsbyUser (Fail)");
                return NotFound(new List<QuizReport>());
            }
            _logger?.LogDebug("<- QuizReport:GetQuizReportsbyUser (Ok)");
            return Ok(quizReports);
        }


        //-------------------------------------------------------------------------------------------------------------

        [HttpGet("GetAllQuizReportAsync", Name = nameof(QuizReportGetAllAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<QuizReport>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<QuizReport>>> QuizReportGetAllAsync()
        {
            _logger?.LogDebug("-> QuizReport::GetAllQuizReportAsync");
            var quizReports = await _quizReportRepository.QuizReportsGetAllAsync();
            if (quizReports == null)
            {
                _logger?.LogDebug("<- QuizReport::GetAllQuizReportAsync (Fail)");
                return NotFound(new List<QuizReport>());
            }
            _logger?.LogDebug("<- QuizReport:GetAllQuizReportAsync (Ok)");
            return Ok(quizReports);
        }

        [HttpGet("GetByIdAsync", Name = nameof(QuizReportGetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(QuizReport))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<QuizReport>> QuizReportGetByIdAsync(int id)
        {
            _logger?.LogDebug("-> QuizReport::GetByIdAsync");
            var quizReport = await _quizReportRepository.QuizReportGetByIdAsync(id);
            if (quizReport == null)
            {
                _logger?.LogDebug("<- QuizReport::GetByIdAsync (Fail)");
                return NotFound();
            }
            _logger?.LogDebug("<- QuizReport:GetByIdAsync (Ok)");
            return Ok(quizReport);
        }

        [HttpGet("GetQuizReportsByQuestionAsync", Name = nameof(QuizReportsGetByQuestionAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<QuizReport>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<QuizReport>>> QuizReportsGetByQuestionAsync(Question question)
        {
            _logger?.LogDebug("-> QuizReport::GetQuizReportsByQuestionAsync");
            var quizReports = await _quizReportRepository.QuizReportGetByQuestionAsync(question);
            if (quizReports == null)
            {
                _logger?.LogDebug("<- QuizReport::GetQuizReportsByQuestionAsync (Fail)");
                return NotFound(new List<QuizReport>());
            }
            _logger?.LogDebug("<- QuizReport:GetQuizReportsByQuestionAsync (Ok)");
            return Ok(quizReports);
        }

        [HttpGet("GetQuizReportsByAnswerAsync", Name = nameof(QuizReportsGetByAnswerAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<QuizReport>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<QuizReport>>> QuizReportsGetByAnswerAsync(Answer answer)
        {
            _logger?.LogDebug("-> QuizReport::GetQuizReportsByAnswerAsync");
            var quizReports = await _quizReportRepository.QuizReportGetByAnswerAsync(answer);
            if (quizReports == null)
            {
                _logger?.LogDebug("<- QuizReport::GetQuizReportsByAnswerAsync (Fail)");
                return NotFound(new List<QuizReport>());
            }
            _logger?.LogDebug("<- QuizReport:GetQuizReportsByAnswerAsync (Ok)");
            return Ok(quizReports);
        }

        [HttpGet("GetQuizReportsbyUserAsync", Name = nameof(QuizReportsGetByUserAsync))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<QuizReport>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<QuizReport>>> QuizReportsGetByUserAsync(User user)
        {
            _logger?.LogDebug("-> QuizReport::GetQuizReportsbyUserAsync");
            var quizReports = await _quizReportRepository.QuizReportGetByUserAsync(user);
            if (quizReports == null)
            {
                _logger?.LogDebug("<- QuizReport::GetQuizReportsbyUserAsync (Fail)");
                return NotFound(new List<QuizReport>());
            }
            _logger?.LogDebug("<- QuizReport:GetQuizReportsbyUserAsync (Ok)");
            return Ok(quizReports);
        }


        //-------------------------------------------------------------------------------------------------------------

        [HttpPost]
        public ActionResult<QuizReport> CreateQuizReport(QuizReport quizReport)
        {
            _quizReportRepository.QuizReportCreate(quizReport);
            return Ok();
        }

        [HttpPut]
        public ActionResult<QuizReport> UpdateQuizReport(QuizReport quizReport)
        {
            _quizReportRepository.QuizReportUpdate(quizReport);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteQuizReport(QuizReport quizReport)
        {
            _quizReportRepository.QuizReportDelete(quizReport);
            return Ok();

        }
    }


    

}
