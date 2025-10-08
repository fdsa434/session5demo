using session5demo.dl.Contexts;
using session5demo.dl.Models.DepartmentModels;
using session5demo.dl.Reposatory.Genericrepo;
using session5demo.dl.Reposatory.DepartmentReposartoy.IdepartmentReposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Reposatory.DepartmentReposartoy
{
   public class DepartmentRepo: GenericReposatory<Department>,IdepartmentRepo
    {
        private readonly demoContexsts d;

        public DepartmentRepo(demoContexsts d):base(d)
        {
            this.d = d;
        }
    }
}
