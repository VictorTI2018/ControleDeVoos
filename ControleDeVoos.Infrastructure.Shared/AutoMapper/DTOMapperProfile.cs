using AutoMapper;
using ControleDeVoos.Domain.Dtos.InformacaoVoo;
using ControleDeVoos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVoos.Infrastructure.Shared.AutoMapper
{
    public class DTOMapperProfile : Profile
    {
        public DTOMapperProfile()
        {
            CreateMap<InformacaoVooDadosDto, InformacaoVoo>();
            CreateMap<InformacaoVoo, InformacaoVooDadosDto>();
        }
    }
}
