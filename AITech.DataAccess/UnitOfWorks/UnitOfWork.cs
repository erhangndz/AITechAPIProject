
using AITech.DataAccess.Context;

namespace AITech.DataAccess.UnitOfWorks
{
    public class UnitOfWork(AppDbContext _context) : IUnitOfWork
    {
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
