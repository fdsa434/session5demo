﻿using session5demo.dl.Models.DepartmentModels;
using session5demo.dl.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Models.EmployeeModels
{
   public class Employee:BaseEntity
    {
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime HiringDate { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }
        [ForeignKey("dept")]
        public int? deptid { get; set; }
        [InverseProperty("emps")]
        public virtual Department dept { get; set; }

    }
}
