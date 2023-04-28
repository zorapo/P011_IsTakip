using FluentValidation;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class MusteriSinifValidator : AbstractValidator<MusteriSinif>
    {
        public MusteriSinifValidator()
        {
            RuleFor(x => x.Tanim).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Aciklama).Length(0, 250);


        }
    }
}
