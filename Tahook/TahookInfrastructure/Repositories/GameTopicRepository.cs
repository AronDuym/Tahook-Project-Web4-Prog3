using Microsoft.EntityFrameworkCore;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Repositories
{
    public class GameTopicRepository : IGameTopicRepository
    {
        private readonly TahookContext _dbcontext;

        public GameTopicRepository(TahookContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void GameTopicCreate(GameTopic gameTopic)
        {
            _dbcontext.GameTopic.Add(gameTopic);
            _dbcontext.SaveChanges();
        }

        public void GameTopicDelete(GameTopic gameTopic)
        {
            _dbcontext.GameTopic.Remove(gameTopic);
            _dbcontext.SaveChanges();
        }

        public GameTopic? GameTopicGetByDescription(string description)
        {
            GameTopic? gameTopic = _dbcontext.GameTopic.FirstOrDefault(x => x.Description == description);
            return gameTopic;
        }

        public Task<GameTopic?> GameTopicGetByDescriptionAsync(string description)
        {
            return _dbcontext.GameTopic.FirstOrDefaultAsync(x => x.Description == description);
        }

        public GameTopic? GameTopicGetById(int id)
        {
            GameTopic? gameTopic = _dbcontext.GameTopic.FirstOrDefault(x => x.Id == id);
            return gameTopic;
        }

        public Task<GameTopic?> GameTopicGetByIdAsync(int id)
        {
            return _dbcontext.GameTopic.FirstOrDefaultAsync(x => x.Id == id);
        }

        public List<GameTopic> GameTopicsGetAll()
        {
            List<GameTopic> gameTopics = _dbcontext.GameTopic.ToList();
            return gameTopics;
        }

        public Task<List<GameTopic>> GameTopicsGetAllAsync()
        {
            return _dbcontext.GameTopic.ToListAsync();
        }

        public void GameTopicUpdate(GameTopic gameTopic)
        {
            _dbcontext.GameTopic.Update(gameTopic);
            _dbcontext.SaveChanges();
        }
    }
}
