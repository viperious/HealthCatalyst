using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Interview_Project.Data.DTO;
using Interview_Project.Data.Models;

namespace Interview_Project
{
    public class AutoMapper
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Person, PersonDto>();
                cfg.CreateMap<Address, AddressDto>()
                .ForMember(dest => dest.AddressType, 
                    option => option
                        .MapFrom(src => src.AddressType.ToString())
                );
                cfg.CreateMap<Interest, InterestDto>();
            });
        }
    }
}