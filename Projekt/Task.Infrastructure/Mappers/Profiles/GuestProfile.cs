using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Task.Core.Domain;
using Task.Infrastructure.Dtos;

namespace Task.Infrastructure.Mappers.Profiles
{
    public class GuestProfile : Profile
    {
        public GuestProfile()
        {
            CreateMap<Guest, GuestDto>().ReverseMap();
        }
    }
}
