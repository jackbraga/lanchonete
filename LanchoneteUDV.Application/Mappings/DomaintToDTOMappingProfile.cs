using AutoMapper;
using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Domain.Entidades;

namespace LanchoneteUDV.Application.Mappings
{
    public class DomaintToDTOMappingProfile : Profile
    {
        public DomaintToDTOMappingProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Escala, EscalaDTO>().ReverseMap();
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}
