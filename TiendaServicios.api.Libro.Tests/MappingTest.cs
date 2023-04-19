using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaServicios.api.Libro.Modelo;
using TiendaServicios.api.Libro.Aplicacion;

namespace TiendaServicios.api.Libro.Tests
{
    public class MappingTest : Profile
    {
        //CreateMap<LibreriaMaterial, LibroMaterialDto>();
        public MappingTest()
        {
            CreateMap<LibreriaMaterial, LibroMaterialDto>();
        }
    }
}
