using session5demo.dl.Reposatory.DepartmentReposartoy.IdepartmentReposatory;
using session5demo.dl.Reposatory.Iemployeerepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.UOW
{
    public interface IUOW
    {
        public IdepartmentRepo departmentrepo { get; set; }
        public IemployeeReposatory employeerepo { get; set; }

        public int complete();
    }
}
