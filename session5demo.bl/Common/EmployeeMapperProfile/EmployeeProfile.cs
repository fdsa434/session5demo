using AutoMapper;
using session5demo.bl.DtoS.EmployeeDtoS;
using session5demo.dl.Models.DepartmentModels;
using session5demo.dl.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5demo.bl.Common.EmployeeMapperProfile
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, Getallemployeesdto>()
           .ForMember(dest => dest.deptname, opt => opt.MapFrom(src => src.dept != null ? src.dept.Name : "N/A"));
            CreateMap<Employee, Getemployeebyiddto>()
        .ForMember(dest => dest.deptname, opt => opt.MapFrom(src => src.dept != null ? src.dept.Name : "N/A"));



            CreateMap<updateemployeedto, Employee>().ReverseMap();
            CreateMap<Employee, createemployeedto>().ReverseMap();


        }
    }
}
