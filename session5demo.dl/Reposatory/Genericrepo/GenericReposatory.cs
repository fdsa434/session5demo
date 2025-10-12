using session5demo.dl.Contexts;
using session5demo.dl.Models;
using session5demo.dl.Reposatory.IGenericreposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.dl.Reposatory.Genericrepo
{
    public class GenericReposatory<tentity> : IGenericreposatory<tentity>  where tentity:BaseEntity
    {
        private readonly demoContexsts d;

        public GenericReposatory(demoContexsts _d)
        {
            this.d = _d;
        }
        public int add(tentity dept)
        {
            d.Set<tentity>().Add(dept);
            return d.SaveChanges();
        }

        public int delete(int id)
        {
            var res = d.Set<tentity>().Find(id);
            d.Set<tentity>().Remove(res);
            return d.SaveChanges();
        }

        public tentity getabyid(int id)
        {
            var res = d.Set<tentity>().Find(id);
            return res;
        }

        public IQueryable<tentity> getall()
        {
            return d.Set<tentity>().Where(d=>d.Id>0);
        }

        public int update(tentity dept)
        {
              var res = d.Set<tentity>().Update(dept);
            return d.SaveChanges();
        }
    }
}
