using AutoMapper;
using session5demo.bl.DtoS.EmployeeDtoS;
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
            CreateMap<Getallemployeesdto, Employee>().ReverseMap();
            CreateMap<Employee, Getemployeebyiddto>().ReverseMap();
            CreateMap<Employee, updateemployeedto>().ReverseMap();
            CreateMap<Employee, createemployeedto>().ReverseMap();


        }
    }
}
