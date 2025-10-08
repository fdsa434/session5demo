using session5demo.dl.Models.EmployeeModels;
using session5demo.dl.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace session5demo.pl.ViewModels.Employeeupdatevm
{
    public class Employeeupdatevm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Employee Type")]
        public string EmployeeType { get; set; }
    }
}
