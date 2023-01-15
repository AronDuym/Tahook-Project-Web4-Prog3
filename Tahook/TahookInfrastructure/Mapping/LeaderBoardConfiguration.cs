using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Mapping
{
    public class LeaderBoardConfiguration : IEntityTypeConfiguration<LeaderBoard>
    {
        public void Configure(EntityTypeBuilder<LeaderBoard> builder)
        {
            builder.ToTable("LeaderBoard");
        }
    }
}
