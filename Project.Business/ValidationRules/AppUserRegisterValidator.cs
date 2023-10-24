using FluentValidation;
using Project.DTO.DTOs.AppUserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen mail alanını doldurunuz.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen isim alanını doldurunuz.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Lütfen soyadi alanını doldurunuz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen şifre alanını doldurunuz.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Lütfen şifre tekrar alanını doldurunuz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Lütfen kullanıcı adı alanını doldurunuz.");
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen isim alanını doldurunuz.");
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen isim alanını doldurunuz.");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Şifreler birbirinden farklı olamaz");
        }
    }
}
