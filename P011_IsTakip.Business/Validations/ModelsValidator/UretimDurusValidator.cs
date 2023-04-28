using FluentValidation;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class UretimDurusValidator : AbstractValidator<UretimDurus>
    {
        public UretimDurusValidator()
        {
            RuleFor(x => x.UretimEmriId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
            RuleFor(x => x.DurusTipId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");

        }
    }
}
