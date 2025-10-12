using session5demo.dl.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Models.DepartmentModels
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string ?Description { get; set; }
        [InverseProperty("dept")]
        public virtual ICollection<Employee> emps { get; set; } = new HashSet<Employee>();


    }
}
