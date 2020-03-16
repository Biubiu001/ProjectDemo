using AutoMapper;
using ProjectDemo.Model;
using S.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Mapper
{
    public class AutoMapperConfigs:Profile
    {
        public AutoMapperConfigs() {

            CreateMap<UserDo, UserDto>()
               .ForMember(s => s.UserName, opts => opts.MapFrom(m => m.Name))
               .ForMember(s => s.M_sex, opts => opts.MapFrom(m => m.sex == 1 ? "美女" : "帅哥"));
            CreateMap<UserDto, UserDo>()
                .ForMember(s => s.Name, opts => opts.MapFrom(m => m.UserName))
                .ForMember(s => s.sex, opts => opts.MapFrom(m => m.M_sex == "男" ? 2 : 1));
             
        
        }
    }
}
