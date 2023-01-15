using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class SessionProfile : Profile
    {
        public SessionProfile()
        {
            CreateMap<Domain.Model.Session, DTO.Model.Session>();
            CreateMap<DTO.Model.Session, Domain.Model.Session>();
        }
    }
}
