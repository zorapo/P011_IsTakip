using FluentValidation;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class UretimEmriValidator : AbstractValidator<UretimEmri>
    {
        public UretimEmriValidator()
        {
            RuleFor(x => x.IsId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.IsEmriTarihi).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.UretimDurum).NotEmpty().NotNull().WithMessage("Zorunlu alan");
        }
    }
}
