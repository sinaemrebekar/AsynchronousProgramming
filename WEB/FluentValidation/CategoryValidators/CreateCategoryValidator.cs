using FluentValidation;
using System.Text.RegularExpressions;
using WEB.Models.CategoryViewModels;

namespace WEB.FluentValidation.CategoryValidators
{
    public partial class CreateCategoryValidator : AbstractValidator<CreateCategoryVM>
    {
        public CreateCategoryValidator()
        {
            Regex regex = MyRegex();

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Bu alan boş geçilemez!")
                .MaximumLength(100)
                .WithMessage("100 karakter sınırını geçtiniz!")
                .MinimumLength(3)
                .WithMessage("En az 3 karakter kullanmalısınız!")
                .Matches(regex)
                .WithMessage("Sadece harf, boşluk ve \"-\" kullanabilirsiniz!");
        }

        [GeneratedRegex("^[a-zA-Z ıİğĞüÜşŞçÇ-]+$")]
        private static partial Regex MyRegex();
    }
}
