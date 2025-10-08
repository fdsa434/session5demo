using session5demo.dl.Contexts;
using session5demo.dl.Models.EmployeeModels;
using session5demo.dl.Reposatory.Genericrepo;
using session5demo.dl.Reposatory.Iemployeerepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Reposatory.Employee_Reposatory
{
    public class EmployeeReposatory : GenericReposatory<Employee>, IemployeeReposatory
    {
        private readonly demoContexsts d;

        public EmployeeReposatory(demoContexsts d):base(d)
        {
            this.d = d;
        }
    }
}
