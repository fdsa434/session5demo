using session5demo.bl.DtoS.DepartmentDtoS;
using session5demo.bl.DtoS.EmployeeDtoS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.Sevices.EmployeeServices
{
    public interface IemployeeServices
    {
        public IEnumerable<Getallemployeesdto> getallservice();
        public IEnumerable<Getallemployeesdto> searchbyname(string ?name);

        public Getemployeebyiddto getdetails(int id);
        public int addemployee(createemployeedto d);
        public int updateemployee(updateemployeedto d);
        public int deleteemployee(int id);
    }
}
