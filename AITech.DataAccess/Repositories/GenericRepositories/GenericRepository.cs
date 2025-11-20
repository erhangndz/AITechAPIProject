using AITech.DataAccess.Context;
using AITech.Entity.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace AITech.DataAccess.Repositories.GenericRepositories
{
    public class GenericRepository<TEntity>(AppDbContext _context) : IRepository<TEntity> where TEntity : BaseEntity
    {
        public async Task CreateAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);

        }
    }
}
