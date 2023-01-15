using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class QuizProfile : Profile
    {
        public QuizProfile()
        {
            CreateMap<Domain.Model.Quiz, DTO.Model.Quiz>();
            CreateMap<DTO.Model.Quiz, Domain.Model.Quiz>();
        }
    }
}
