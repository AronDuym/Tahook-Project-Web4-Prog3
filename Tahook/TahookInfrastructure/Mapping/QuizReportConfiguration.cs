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
        }
    }
}
