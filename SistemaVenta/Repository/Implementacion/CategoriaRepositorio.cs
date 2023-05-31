using Microsoft.EntityFrameworkCore;
using SistemaVenta.Models;
using SistemaVenta.Repository.Contratos;

namespace SistemaVenta.Repository.Implementacion
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly DBVentaAngularContext _dbContext;

        public CategoriaRepositorio(DBVentaAngularContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Categoria>> Lista()
        {
            try
            {
                return await _dbContext.Categoria.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
