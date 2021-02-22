using AutoMapper;
using Meta.Backend.DTOs;
using Meta.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Backend.Profiles
{
    public class ContatosProfile : Profile
    {
        public ContatosProfile()
        {
            CreateMap<Contato, ContatoReadDto>();
            CreateMap<ContatoCreateDto, Contato>();
            CreateMap<ContatoUpdateDto, Contato>();
        }
    }
}
