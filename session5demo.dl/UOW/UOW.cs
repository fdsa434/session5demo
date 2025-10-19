using session5demo.dl.Contexts;
using session5demo.dl.Reposatory.DepartmentReposartoy;
using session5demo.dl.Reposatory.DepartmentReposartoy.IdepartmentReposatory;
using session5demo.dl.Reposatory.Employee_Reposatory;
using session5demo.dl.Reposatory.Iemployeerepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.UOW
{
    public class UOW : IUOW
    {
        private readonly demoContexsts c;

        public UOW(demoContexsts c)
        {
            this.c = c;
            departmentrepo = new DepartmentRepo(c);
            employeerepo = new EmployeeReposatory(c);
        }
        public IdepartmentRepo departmentrepo { get ; set; }
        public IemployeeReposatory employeerepo { get; set ; }

        public int complete()
        {
           return c.SaveChanges();
        }
    }
}
