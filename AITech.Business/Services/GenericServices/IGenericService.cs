namespace AITech.Business.Services.GenericServices
{
    public interface IGenericService<TResultDto,TCreateDto,TUpdateDto>
    {
        Task<List<TResultDto>> TGetAllAsync();
        Task<TResultDto> TGetByIdAsync(int id);
        Task TCreateAsync(TCreateDto createDto);
        Task TUpdateAsync(TUpdateDto updateDto);
        Task TDeleteAsync(int id);

    }
}
