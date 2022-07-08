using Microsoft.EntityFrameworkCore;
using DBCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBCodeFirst.Configs
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(50);
        }
    }
}
