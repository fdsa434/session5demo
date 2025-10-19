
using AutoMapper;
using session5demo.bl.DtoS.DepartmentDtoS;
using session5demo.dl.Models.DepartmentModels;
using session5demo.dl.Reposatory.DepartmentReposartoy;
using session5demo.dl.Reposatory.DepartmentReposartoy.IdepartmentReposatory;
using session5demo.dl.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.Sevices.DpartmentServices
{
        public class DepartmentServices : IdepartmentServices
        {
            private readonly IUOW dep;
        private readonly IMapper m;

        public DepartmentServices(IUOW dep, IMapper m)
            {
                this.dep = dep;
            this.m = m;
        }

            public int adddept(createdepartmentdto d)
            {

                dep.departmentrepo.add(m.Map<Department>(d));
                return dep.complete();
            }

            public int deletedepartment(int id)
            {
                 dep.departmentrepo.delete(id);
                return dep.complete();

            }

            public IEnumerable<Getalldepartmentsdto> getallservice()
            {

                return m.Map<IEnumerable<Getalldepartmentsdto>>(dep.departmentrepo.getall().ToList());
            }

            public Getdepartmentbyiddto getdetails(int id)
            {
                return m.Map<Getdepartmentbyiddto>(dep.departmentrepo.getabyid(id));
            }

            public int updatedept(updatedeprtmentdto d)
            {

                var res = m.Map<Department>(d);
                dep.departmentrepo.update(res);
                return dep.complete();


            }
        }
}

    

