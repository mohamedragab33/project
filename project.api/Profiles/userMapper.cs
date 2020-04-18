using AutoMapper;
using project.api.EntityModels;
using project.api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.Profiles
{
    public class userMapper : Profile
    {
        public userMapper()
        {
            CreateMap<User, register>();
            CreateMap<UserForCreation, User>();
             
        }

    }
}
