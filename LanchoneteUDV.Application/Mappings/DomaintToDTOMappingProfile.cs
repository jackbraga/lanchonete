using AutoMapper;
using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Mappings
{
    public class DomaintToDTOMappingProfile : Profile
    {
        public DomaintToDTOMappingProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
        }
    }
}
