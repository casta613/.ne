using SistemaVenta.Models;

namespace SistemaVenta.Repository.Contratos
{
    public interface IRolRepositorio
    {
        Task<List<Rol>> Lista();
    }
}
