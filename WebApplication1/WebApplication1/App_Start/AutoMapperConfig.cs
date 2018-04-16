using AutoMapper;

namespace WebApplication1.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new EmployeeProfile());
            });
        }
    }
}