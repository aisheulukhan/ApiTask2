using ApiTask1.Dtos;
using ApiTask1.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTask1.Mapping
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Actor, ActorCreateDto>().ReverseMap();
            CreateMap<Actor, ActorCreateDto>().ReverseMap();
        }
    }
}
