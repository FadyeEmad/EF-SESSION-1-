using EF_SESSION_1_DEMO.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SESSION_1_DEMO.configrations
{
    internal class employeeconfigration : IEntityTypeConfiguration<employee>
    {
        public void Configure(EntityTypeBuilder<employee> builder)
        {
            builder.HasKey(e => e.EmpId);
            builder.Property(e => e.EmpId).UseIdentityColumn(1, 1);
            builder.Property(e => e.Name).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(E => E.Salary).HasColumnType("money");
        }
    }
}
