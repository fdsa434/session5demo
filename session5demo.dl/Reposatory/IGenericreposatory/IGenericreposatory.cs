using session5demo.dl.Models;
using session5demo.dl.Models.DepartmentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Reposatory.IGenericreposatory
{
    public interface IGenericreposatory<tentity> where tentity:BaseEntity
    {
        public IQueryable<tentity> getall();
        public tentity getabyid(int id);
        public int update(tentity dept);
        public int add(tentity dept);
        public int delete(int id);
    }
}
