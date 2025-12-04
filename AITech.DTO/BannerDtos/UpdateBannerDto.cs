namespace AITech.DTO.BannerDtos
{
    public record UpdateBannerDto(int Id, string? Title, string? Description, string? ImageUrl, bool IsActive)
    {
    }
}
