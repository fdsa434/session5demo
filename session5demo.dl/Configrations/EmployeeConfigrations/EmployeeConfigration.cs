using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using session5demo.dl.Models.EmployeeModels;
using session5demo.dl.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Configrations.EmployeeConfigrations
{
    public class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Address).HasColumnType("varchar(50)");
            builder.Property(p => p.EmployeeType)
           .HasConversion((emp) => emp.ToString(), g => (EmployeeType)  Enum.Parse(typeof(EmployeeType), g));
            builder.Property(p => p.Gender)
           .HasConversion((gender) => gender.ToString(), g => (Gender)Enum.Parse(typeof(Gender), g));

        }
    }
}
