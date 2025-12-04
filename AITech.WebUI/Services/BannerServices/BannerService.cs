using AITech.WebUI.DTOs.BannerDtos;

namespace AITech.WebUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _client;

        public BannerService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7203/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateBannerDto BannerDto)
        {
            await _client.PostAsJsonAsync("Banners", BannerDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Banners/" + id);
        }

        public async Task<List<ResultBannerDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultBannerDto>>("Banners");

        }

        public async Task<UpdateBannerDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateBannerDto>("Banners/" + id);
        }

        public async Task UpdateAsync(UpdateBannerDto BannerDto)
        {
            await _client.PutAsJsonAsync("Banners", BannerDto);
        }


        public async Task MakeActiveAsync(int id)
        {
            await _client.PatchAsync("banners/makeActive/" + id, null);
        }

        public async Task MakePassiveAsync(int id)
        {
            await _client.PatchAsync("banners/makePassive/" + id, null);
        }

        
    }
}
