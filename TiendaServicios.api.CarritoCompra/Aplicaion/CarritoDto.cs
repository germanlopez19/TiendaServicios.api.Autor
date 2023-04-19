using System;
using System.Collections.Generic;

namespace TiendaServicios.api.CarritoCompra.Aplicaion
{
    public class CarritoDto
    { 
        public int CarritoId { get; set; }  
        public DateTime? FechaCreacionSesion { get; set; }
        public List<CarritoDetalleDto> ListaProductos { get; set; }
    }
}
