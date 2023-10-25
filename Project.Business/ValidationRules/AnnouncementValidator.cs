using FluentValidation;
using Project.DTO.DTOs.AnnouncementDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.ValidationRules
{
  public  class AnnouncementValidator: AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Mesaj alanı boş geçilemez.");
        }
    }
}
