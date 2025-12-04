using AITech.WebUI.DTOs.BannerDtos;

namespace AITech.WebUI.Services.BannerServices
{
    public interface IBannerService
    {
        Task MakeActiveAsync(int id);
        Task MakePassiveAsync(int id);
        Task<List<ResultBannerDto>> GetAllAsync();
        Task<UpdateBannerDto> GetByIdAsync(int id);
        Task CreateAsync(CreateBannerDto BannerDto);
        Task UpdateAsync(UpdateBannerDto BannerDto);
        Task DeleteAsync(int id);
    }
}
