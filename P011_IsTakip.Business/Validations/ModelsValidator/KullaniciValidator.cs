using FluentValidation;
using Microsoft.Extensions.Configuration;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Validations.ModelsValidator
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.Soyad).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.KullaniciKodu).NotEmpty().NotNull().WithMessage("Zorunlu alan");
            RuleFor(x => x.KullaniciSifre).NotEmpty().NotNull().WithMessage("Zorunlu alan");

        }

    }
}
