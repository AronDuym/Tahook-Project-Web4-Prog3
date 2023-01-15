using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Domain.Model.Question, DTO.Model.Question>();
            CreateMap<DTO.Model.Question, Domain.Model.Question>();
        }
    }
}
