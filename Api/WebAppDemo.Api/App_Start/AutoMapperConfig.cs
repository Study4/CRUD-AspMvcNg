using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDemo.Api.Models.Dtos;
using WebAppDemo.Model;

namespace WebAppDemo.Api.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<EmpProfile>();
            });
        }
        public class EmpProfile : Profile
        {
            protected override void Configure()
            {
                CreateMap<Employee, EmployeeDto>().ReverseMap();
            }
        }
    }
}
