using AutoMapper;
using session5demo.bl.DtoS.DepartmentDtoS;
using session5demo.dl.Models.DepartmentModels;
using session5demo.dl.Reposatory.DepartmentReposartoy;
using session5demo.dl.Reposatory.DepartmentReposartoy.IdepartmentReposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.Sevices.DpartmentServices
{
    public class DepartmentServices : IdepartmentServices
    {
        private readonly IdepartmentRepo dep;
        private readonly IMapper m;

        public DepartmentServices(IdepartmentRepo d,IMapper m)
        {
           dep = d;
            this.m = m;
        }

        public int adddept(createdepartmentdto d)
        {
            
           return dep.add(m.Map<Department>(d));
        }

        public int deletedepartment(int id)
        {
            return dep.delete(id);
        }

        public IEnumerable<Getalldepartmentsdto> getallservice()
        {
           
            return m.Map<IEnumerable<Getalldepartmentsdto>>(dep.getall().ToList());
        }

        public Getdepartmentbyiddto getdetails(int id)
        {
            return m.Map<Getdepartmentbyiddto>(dep.getabyid(id));
        }

        public int updatedept(updatedeprtmentdto d)
        {
           
            var res=m.Map<Department>(d);
           return dep.update(res);
        }
    }
}
