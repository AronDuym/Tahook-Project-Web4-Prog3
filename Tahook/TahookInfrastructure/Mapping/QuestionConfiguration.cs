using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Mapping
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Question");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Quiz).WithMany(x => x.Questions).HasForeignKey(x => x.QuizId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
