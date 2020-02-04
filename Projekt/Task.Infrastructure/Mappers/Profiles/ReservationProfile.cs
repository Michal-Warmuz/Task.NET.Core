using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Task.Core.Domain;
using Task.Infrastructure.Dtos;

namespace Task.Infrastructure.Mappers.Profiles
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<Reservation, ReservationDto>().ReverseMap();
        }
    }
}
