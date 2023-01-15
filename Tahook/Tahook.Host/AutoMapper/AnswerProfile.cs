using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<Domain.Model.Answer, DTO.Model.Answer>();
            CreateMap<DTO.Model.Answer, Domain.Model.Answer>();
        }
    }
}
