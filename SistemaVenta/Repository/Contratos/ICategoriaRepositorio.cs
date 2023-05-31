using SistemaVenta.Models;

namespace SistemaVenta.Repository.Contratos
{
    public interface ICategoriaRepositorio
    {
        Task<List<Categoria>> Lista();
    }
}
