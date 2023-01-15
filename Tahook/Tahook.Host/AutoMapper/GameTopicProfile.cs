using AutoMapper;

namespace Tahook.Api.AutoMapper
{
    public class GameTopicProfile : Profile
    {
        public GameTopicProfile()
        {
            CreateMap<Domain.Model.GameTopic, DTO.Model.GameTopic>();
            CreateMap<DTO.Model.GameTopic, Domain.Model.GameTopic>();
        }
    }
}
