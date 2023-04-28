using FluentValidation;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class AjandaValidator : AbstractValidator<Ajanda>
    {
        public AjandaValidator()
        {
            RuleFor(x => x.MusteriId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.NotTarihi).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Aciklama).Length(0, 250);
        }
    }
}
