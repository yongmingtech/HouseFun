using System;
using AutoMapper;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.App_Start
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employees, EmployeeViewModel>().ForMember(dest => dest.FullName,
                opt => opt.MapFrom(src => $"{src.LastName} - {src.LastName}"));
        }
    }
}