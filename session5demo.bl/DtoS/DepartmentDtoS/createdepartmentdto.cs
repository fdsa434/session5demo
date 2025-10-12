using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.DtoS.DepartmentDtoS
{
    public class createdepartmentdto
    {

        [Required(ErrorMessage = "name is req")]
        public string Name { get; set; }
        [Required(ErrorMessage = "code is req")]

        public string Code { get; set; }
        public string? Description { get; set; }
        
    }
}
