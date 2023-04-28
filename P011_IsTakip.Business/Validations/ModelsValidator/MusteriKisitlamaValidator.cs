using FluentValidation;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class MusteriKisitlamaValidator : AbstractValidator<MusteriKisitlama>
    {
        public MusteriKisitlamaValidator()
        {
            RuleFor(x => x.MusteriId).NotEmpty().NotNull().NotEqual(0).When(x => x.Kisitlama == true).WithMessage("Zorunlu alan");

        }
    }
}
