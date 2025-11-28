namespace AITech.DTO.ProjectDtos
{
    public record UpdateProjectDto(int Id,
                                   string Title,
                                   string ImageUrl,
                                   int CategoryId);
    
}
