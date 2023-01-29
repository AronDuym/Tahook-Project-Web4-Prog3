using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Mapping
{
    public class GameTopicConfiguration : IEntityTypeConfiguration<GameTopic>
    {
        public void Configure(EntityTypeBuilder<GameTopic> builder)
        {
            builder.ToTable("GameTopic");
            builder.HasKey(x => x.Id);
        }
    }
}
