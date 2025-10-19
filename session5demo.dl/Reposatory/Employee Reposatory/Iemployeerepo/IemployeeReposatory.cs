using session5demo.dl.Contexts;
using session5demo.dl.Models.EmployeeModels;
using session5demo.dl.Reposatory.IGenericreposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Reposatory.Iemployeerepo
{
    public interface IemployeeReposatory: IGenericreposatory<Employee>
    {
        public IEnumerable<Employee> searchbyname(string? name);
    }
}
