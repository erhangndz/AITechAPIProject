using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.BannerRepositories
{
    public class BannerRepository : GenericRepository<Banner>, IBannerRepository
    {
        public BannerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task MakeActiveAsync(Banner banner)
        {
            banner.IsActive =true;
        }

        public async Task MakePassiveAsync(Banner banner)
        {
            banner.IsActive=false;
        }
    }
}
