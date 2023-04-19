using Microsoft.EntityFrameworkCore;
using TiendaServicios.api.Libro.Modelo;

namespace TiendaServicios.api.Libro.Persistencia
{
    public class ContextoLibreria : DbContext
    {
        public ContextoLibreria() { }
        public ContextoLibreria(DbContextOptions options) : base(options){ }

        public virtual DbSet<LibreriaMaterial> LiberiaMaterial { get; set; }
    }
}
