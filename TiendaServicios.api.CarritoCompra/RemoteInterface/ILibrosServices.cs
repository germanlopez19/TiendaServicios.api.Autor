using System;
using System.Threading.Tasks;
using TiendaServicios.api.CarritoCompra.RemoteModel;

namespace TiendaServicios.api.CarritoCompra.RemoteInterface
{
    public interface ILibrosServices
    {
        Task<(bool resultado, LibroRemote Libro, string ErrorMessage)> GetLibro(Guid LibroId);
    }
}
