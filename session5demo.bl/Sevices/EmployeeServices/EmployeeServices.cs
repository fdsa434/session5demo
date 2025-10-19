using AutoMapper;
using session5demo.bl.Common.attachmentCommon;
using session5demo.bl.DtoS.DepartmentDtoS;
using session5demo.bl.DtoS.EmployeeDtoS;
using session5demo.dl.Models.DepartmentModels;
using session5demo.dl.Models.EmployeeModels;
using session5demo.dl.Reposatory.Employee_Reposatory;
using session5demo.dl.Reposatory.Iemployeerepo;
using session5demo.dl.UOW;
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
        private readonly IUOW emp;
        private readonly IMapper m;
        private readonly Iattachmentservice i;

        public EmployeeServices(IUOW emp,IMapper m,Iattachmentservice i)
        {
            this.emp = emp;
            this.m = m;
            this.i = i;
        }
        public int addemployee(createemployeedto d)
        {
            Employee e = new Employee();
            if (d.file is not null)
            {
                e.FileName = i.addattachment(d.file, "assets");
            }
            emp.employeerepo.add(m.Map<Employee>(d));
           
            
            return emp.complete();
        }

        public int deleteemployee(int id)
        {
            var em = emp.employeerepo.getabyid(id);
            Employee e = new Employee();
            if(e.FileName is not null)
            {
                var fpath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","assets","images",e.FileName);
                i.delete(fpath);
            }
            
            emp.employeerepo.delete(id);
            return emp.complete();

        }
        public int updateemployee(updateemployeedto d)
        {
            Employee e= new Employee();
            var res = m.Map<Employee>(d);
            if (d.file is not null)
            {
                if (e.FileName is not null)
                {
                    var fpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "images", e.FileName);
                    i.delete(fpath);
                }
               e.FileName= i.addattachment(d.file,"assets");
            }

            emp.employeerepo.update(res);
            return emp.complete();

        }

        public IEnumerable<Getallemployeesdto> getallservice()
        {
            return m.Map<IEnumerable<Getallemployeesdto>>(emp.employeerepo.getall().ToList());
        }
        public Getemployeebyiddto getdetails(int id)
        {
            return m.Map<Getemployeebyiddto>(emp.employeerepo.getabyid(id));
        }

        public IEnumerable<Getallemployeesdto> searchbyname(string? name)
        {
            if (name is null)
            {
                return m.Map<IEnumerable<Getallemployeesdto>>(emp.employeerepo.getall().ToList());
            }
            else
            {
                return m.Map<IEnumerable<Getallemployeesdto>>(emp.employeerepo.searchbyname(name).ToList());
            }
        }

       


    }
}
