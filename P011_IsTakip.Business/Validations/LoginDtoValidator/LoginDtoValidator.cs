using FluentValidation;
using P011_IsTakip.Entities.Classes;
using P011_IsTakip.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Validations.LoginDtoValidator
{
    public class LoginDtoValidator : AbstractValidator<LoginDto>
	{
       public LoginDtoValidator()
		{
			RuleFor(x => x.KullaniciKodu).NotEmpty().NotNull().WithMessage("Zorunlu alan");
			RuleFor(x => x.KullaniciSifre).NotEmpty().NotNull().WithMessage("Zorunlu alan");			
		}
	}
}
