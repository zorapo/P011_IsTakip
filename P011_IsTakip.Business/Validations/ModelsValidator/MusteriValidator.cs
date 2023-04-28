using FluentValidation;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class MusteriValidator : AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(x => x.Tanim).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Adres).NotEmpty().NotNull().WithMessage("Zorunlu alan").MinimumLength(10).WithMessage("Adresiniz 10 karakterden az olamaz.");
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("Zorunlu alan").EmailAddress().WithMessage("Email adresinizi doğru formatta giriniz.");
        }

    }
}
