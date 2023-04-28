using FluentValidation;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class IsValidator : AbstractValidator<Is>
    {
        public IsValidator()
        {
            RuleFor(x => x.MusteriId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.MalzemeTipId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.KalinlikId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.IsOnceligi).NotNull().NotEmpty().WithMessage("Zorunlu alan");
            RuleFor(x => x.MusteriSiparisNo).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Termin).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Fiyat).NotEmpty().NotNull().WithMessage("Zorunlu alan");

        }
    }
}
