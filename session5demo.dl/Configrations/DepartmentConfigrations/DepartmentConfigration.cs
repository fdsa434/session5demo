using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using session5demo.dl.Models.DepartmentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Configrations.DepartmentConfigrations
{
    public class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department>  builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Code).HasColumnType("varchar(50)");
            builder.Property(p => p.Name).HasColumnType("varchar(50)");
            builder.Property(p => p.Description).HasColumnType("varchar(50)");

        }
    }
}
