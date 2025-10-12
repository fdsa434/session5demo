using AutoMapper;
using session5demo.bl.DtoS.DepartmentDtoS;
using session5demo.bl.DtoS.EmployeeDtoS;
using session5demo.dl.Models.DepartmentModels;
using session5demo.dl.Models.EmployeeModels;
using session5demo.dl.Reposatory.Employee_Reposatory;
using session5demo.dl.Reposatory.Iemployeerepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.Sevices.EmployeeServices
{
    public class EmployeeServices : IemployeeServices
    {
        private readonly IemployeeReposatory emp;
        private readonly IMapper m;

        public EmployeeServices(IemployeeReposatory emp,IMapper m)
        {
            this.emp = emp;
            this.m = m;
        }
        public int addemployee(createemployeedto d)
        {
            return emp.add(m.Map<Employee>(d));
        }

        public int deleteemployee(int id)
        {
            return emp.delete(id);
        }

        public IEnumerable<Getallemployeesdto> getallservice()
        {
            return m.Map<IEnumerable<Getallemployeesdto>>(emp.getall().ToList());
        }

        public Getemployeebyiddto getdetails(int id)
        {
            return m.Map<Getemployeebyiddto>(emp.getabyid(id));
        }

        public int updateemployee(updateemployeedto d)
        {
          var res = m.Map<Employee>(d);
            return emp.update(res);
        }

        
    }
}
