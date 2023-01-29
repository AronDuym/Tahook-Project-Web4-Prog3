using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Mapping
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("Quiz");
            builder.HasKey(x => x.Id);
            //builder.HasOne(x => x.GameTopic).WithMany(y => y.Quizzes).HasForeignKey(x => x.GameTopic).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Users).WithOne(y => y.Quiz).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
