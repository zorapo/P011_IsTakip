using FluentValidation;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class DepoEnvanterValidator : AbstractValidator<DepoEnvanter>
    {
        public DepoEnvanterValidator()
        {
            RuleFor(x => x.DepoId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.DepoRafId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.MalzemeTipId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.KalinlikId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.En).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Boy).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Adet).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Agirlik).NotEmpty().NotNull().WithMessage("Zorunlu alan");

        }
    }
}
