using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Domain.Model.User, DTO.Model.User>();
            CreateMap<DTO.Model.User, Domain.Model.User>();
        }
    }
}
