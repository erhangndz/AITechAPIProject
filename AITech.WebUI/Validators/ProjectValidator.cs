using AITech.WebUI.DTOs.ProjectDtos;
using FluentValidation;

namespace AITech.WebUI.Validators
{
    public class ProjectValidator: AbstractValidator<CreateProjectDto>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz")
                                .MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Url boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori boş bırakılamaz");
        }
    }
}
