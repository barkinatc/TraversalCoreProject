using AutoMapper;
using Project.DTO.DTOs.AnnouncementDTOs;
using Project.DTO.DTOs.AppUserDTOs;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AnnouncementAddDTO, Announcement>().ReverseMap();


            CreateMap<AppUserLoginDTO, AppUser>().ReverseMap(); 
            //CreateMap<AppUser, AppUserLoginDTO>();

            CreateMap<AppUserRegisterDTO, AppUser>().ReverseMap();
            //CreateMap<AppUser, AppUserRegisterDTO>();
        }
    }
}
