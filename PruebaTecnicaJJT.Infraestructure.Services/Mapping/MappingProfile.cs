using AutoMapper;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Business.Models;

namespace PruebaTecnicaJJT.Infraestructure.Services.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DTOClientes, Clientes>().ReverseMap();
            CreateMap<DTODepartamentosColombia, DepartamentosColombia>().ReverseMap();
            CreateMap<DTODivisionPoliticaColombia, DivisionPoliticaColombia>().ReverseMap();
            CreateMap<DTOPais, Pais>().ReverseMap();
            CreateMap<DTOTipoIdentificacion, TipoIdentificacion>().ReverseMap();
            CreateMap<DTOClientesGetAll, ClientesGetAll>().ReverseMap();
        }
    }
}
