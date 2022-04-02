using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnomaliesApi.DTOs;
using AnomaliesApi.Entities;
using AutoMapper;

namespace AnomaliesApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<RessourceDTO, Ressource>().ReverseMap();
            CreateMap<CreateRessourceDTO, Ressource>();

        }

    }
}