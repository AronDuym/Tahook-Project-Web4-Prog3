using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class LeaderBoardProfile : Profile
    {
        public LeaderBoardProfile()
        {
            CreateMap<Domain.Model.LeaderBoard, DTO.Model.LeaderBoard>();
            CreateMap<DTO.Model.LeaderBoard, Domain.Model.LeaderBoard>();
        }
    }
}
