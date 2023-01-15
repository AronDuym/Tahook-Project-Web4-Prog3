using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Domain.Model.Role, DTO.Model.Role>();
            CreateMap<DTO.Model.Role, Domain.Model.Role>();
        }
    }
}
