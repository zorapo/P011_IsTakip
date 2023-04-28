using FluentValidation;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class KalinlikValidator : AbstractValidator<Kalinlik>
    {
        public KalinlikValidator()
        {
            RuleFor(x => x.Tanim).NotEmpty().NotNull().WithMessage("Zorunlu alan");

        }
    }
}
