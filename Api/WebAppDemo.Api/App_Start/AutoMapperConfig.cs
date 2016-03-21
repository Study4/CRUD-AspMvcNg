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
                cfg.AddProfile<FpsProfile>();
                //cfg.AddProfile<IdentityProfile>();
            });
        }
        public class FpsProfile : Profile
        {
            protected override void Configure()
            {
                CreateMap<Employee, EmployeeDto>().ReverseMap();
            }
        }

        //public class IdentityProfile : Profile
        //{
        //    protected override void Configure()
        //    {
        //        Mapper.CreateMap<User, UserDto>().ReverseMap();
        //    }
        //}

    }
}
