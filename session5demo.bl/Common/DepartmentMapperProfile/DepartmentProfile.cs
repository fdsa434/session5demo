using AutoMapper;
using session5demo.bl.DtoS.DepartmentDtoS;
using session5demo.dl.Models.DepartmentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.Common.MapperProfile
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, Getalldepartmentsdto>().ReverseMap();
            CreateMap<Department, Getdepartmentbyiddto>().ReverseMap();
            CreateMap<Department, createdepartmentdto>().ReverseMap();
            CreateMap<Department, updatedeprtmentdto>().ReverseMap();




        }
    }
}
