using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.BannerRepositories
{
    public interface IBannerRepository: IRepository<Banner>
    {

        Task MakeActiveAsync(Banner banner);
        Task MakePassiveAsync(Banner banner);


    }
}
