using Microsoft.EntityFrameworkCore;
using Tahook.DTO.Model;
using Tahook.Infrastructure.Mapping;

namespace Tahook.Infrastructure
{
    public class TahookContext: DbContext
    {
        #region
        //Dbsets
        public DbSet<Answer> Answers { get; set; }
        public DbSet<GameTopic> GameTopics { get; set; }

        public DbSet<LeaderBoard> LeaderBoards { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<QuizReport> QuizReports { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<User> Users { get; set; }

        #endregion

        public TahookContext(DbContextOptions<TahookContext> options) :base(options)
        {

        }

        public TahookContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress_new;Initial Catalog=TahookDatabase;Integrated Security=True;MultipleActiveResultSets=true;Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new GameTopicConfiguration());
            modelBuilder.ApplyConfiguration(new LeaderBoardConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new QuizConfiguration());
            modelBuilder.ApplyConfiguration(new QuizReportConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new SessionConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
