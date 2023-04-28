using FluentValidation;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class IsDosyaValidator : AbstractValidator<IsDosya>
    {
        public IsDosyaValidator()
        {
            RuleFor(x => x.IsId).NotEmpty().NotNull().NotEqual(0).WithMessage("Zorunlu alan");
        }
    }
}
