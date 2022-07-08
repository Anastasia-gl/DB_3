using Microsoft.EntityFrameworkCore;
using DBCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBCodeFirst.Configs
{
    internal class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(50);
        }
    }
}
