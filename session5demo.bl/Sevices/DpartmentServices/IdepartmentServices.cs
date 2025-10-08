using session5demo.bl.DtoS.DepartmentDtoS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.Sevices.DpartmentServices
{
    public interface IdepartmentServices
    {
        public IEnumerable<Getalldepartmentsdto> getallservice();
        public Getdepartmentbyiddto getdetails(int id);
        public int adddept(createdepartmentdto d);
        public int updatedept(updatedeprtmentdto d);
        public int deletedepartment(int id);
    }
}
