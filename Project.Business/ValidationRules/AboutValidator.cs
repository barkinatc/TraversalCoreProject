using FluentValidation;
using Project.ENTITIES.Concrete;

namespace Project.Business.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen bir açıklama giriniz!");
        }
    }
}
