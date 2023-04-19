using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TiendaServicios.api.CarritoCompra.Modelo;

namespace TiendaServicios.api.CarritoCompra.Persistensia
{
    public class CarritoContexto : DbContext
    {
        public CarritoContexto(DbContextOptions<CarritoContexto> options) : base(options) { }
        public DbSet<CarritoSesion> CarritoSesion { get; set; }
        public DbSet<CarritoSesionDetalle> CarritoSesionDetalle { get; set; }
    }
}
