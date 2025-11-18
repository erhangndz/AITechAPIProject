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
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
