using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class QuizReportProfile : Profile
    {
        public QuizReportProfile()
        {
            CreateMap<Domain.Model.QuizReport, DTO.Model.QuizReport>();
            CreateMap<DTO.Model.QuizReport, Domain.Model.QuizReport>();
        }
    }
}
