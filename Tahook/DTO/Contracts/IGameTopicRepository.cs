using Tahook.DTO.Model;

namespace Tahook.DTO.Contracts
{
    public interface IGameTopicRepository
    {
        List<GameTopic> GameTopicsGetAll();
        Task<List<GameTopic>> GameTopicsGetAllAsync();

        GameTopic? GameTopicGetById(int id);
        GameTopic? GameTopicGetByDescription(string description);

        Task<GameTopic?> GameTopicGetByIdAsync(int id);
        Task<GameTopic?> GameTopicGetByDescriptionAsync(string description);

        void GameTopicCreate(GameTopic gameTopic);
        void GameTopicUpdate(GameTopic gameTopic);
        void GameTopicDelete(GameTopic gameTopic);
    }
}
