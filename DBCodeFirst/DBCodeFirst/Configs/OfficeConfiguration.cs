using Microsoft.EntityFrameworkCore;
using DBCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBCodeFirst.Configs
{
    internal class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(e => e.Title).HasMaxLength(100);
            builder.Property(e => e.Location).HasMaxLength(100);
        }
    }
}
