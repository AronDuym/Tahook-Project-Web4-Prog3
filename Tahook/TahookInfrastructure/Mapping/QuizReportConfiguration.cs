using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Mapping
{
    public class QuizReportConfiguration : IEntityTypeConfiguration<QuizReport>
    {
        public void Configure(EntityTypeBuilder<QuizReport> builder)
        {
            builder.ToTable("QuizReport");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Question);
            builder.HasOne(x => x.Answer);
            builder.HasOne(x => x.User);
        }
    }
}
