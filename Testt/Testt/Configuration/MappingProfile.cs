using ApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Testt.Controllers.Model;

namespace Testt.Configuration
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>();
        }
       
    }
}
