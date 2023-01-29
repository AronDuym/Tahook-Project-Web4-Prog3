using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Tahook.DTO.Model;
using Tahook.Infrastructure.Mapping;

namespace Tahook.Infrastructure
{
    public class TahookContext: DbContext
    {
        #region DBSETS
        //Dbsets
        public DbSet<Answer> Answer { get; set; }
        public DbSet<GameTopic> GameTopic { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Quiz> Quiz { get; set; }

        public DbSet<QuizReport> QuizReport { get; set; }

        public DbSet<Role> Role { get; set; }

        //public DbSet<Session> Session { get; set; }

        public DbSet<User> User { get; set; }

        #endregion

        #region Properties
        private IConfiguration _configuration;
        #endregion

        public TahookContext(DbContextOptions<TahookContext> options, IConfiguration configuration) :base(options)
        {
            _configuration = configuration;
        }

        public TahookContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var cs = _configuration.GetConnectionString("DefaultConnection");

            optionsBuilder
                .UseSqlServer(cs)
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new GameTopicConfiguration());
           //modelBuilder.ApplyConfiguration(new LeaderBoardConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new QuizConfiguration());
            modelBuilder.ApplyConfiguration(new QuizReportConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            //modelBuilder.ApplyConfiguration(new SessionConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
