using AM.Infrastructure.Models;
using AM.Web.Models.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserPostsVM>();
            CreateMap<User, UserDetailsVM>();
            CreateMap<Post, PostVM>();
        }
    }
}