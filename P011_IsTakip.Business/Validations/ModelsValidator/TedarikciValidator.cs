using FluentValidation;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class TedarikciValidator : AbstractValidator<Tedarikci>
    {
        public TedarikciValidator()
        {

            RuleFor(x => x.Tanim).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("Zorunlu alan").EmailAddress().WithMessage("Email adresinizi doğru formatta giriniz.");


        }
    }
}
