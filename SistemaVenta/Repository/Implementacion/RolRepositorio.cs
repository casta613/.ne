using Microsoft.EntityFrameworkCore;
using SistemaVenta.Models;
using SistemaVenta.Repository.Contratos;
using System.Linq.Expressions;

namespace SistemaVenta.Repository.Implementacion
{
    public class RolRepositorio : IRolRepositorio
    {
        private readonly DBVentaAngularContext _dbContext;

        public RolRepositorio(DBVentaAngularContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Rol>> Lista()
        {
            try
            {
                return await _dbContext.Rols.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
