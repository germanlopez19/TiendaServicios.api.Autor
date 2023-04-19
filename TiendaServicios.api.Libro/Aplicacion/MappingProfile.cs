using AutoMapper;
using TiendaServicios.api.Libro.Modelo;

namespace TiendaServicios.api.Libro.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
        CreateMap<LibreriaMaterial, LibroMaterialDto>();
        }
    }
}
