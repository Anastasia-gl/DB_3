using Microsoft.EntityFrameworkCore;
using DBCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBCodeFirst.Configs
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
         //   builder.Property(e => Convert.ToDateTime(e.HiredDate.ToString("yyyy-MM-dd HH:mm:ss:fffffff")));
            builder.Property(e => e.FirstName).HasMaxLength(50);
            builder.Property(e => e.LastName).HasMaxLength(50);
        }
    }
}
