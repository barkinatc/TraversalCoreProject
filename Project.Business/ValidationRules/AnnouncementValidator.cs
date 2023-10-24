using FluentValidation;

using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.ValidationRules
{
  public  class AnnouncementValidator: AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Mesaj alanı boş geçilemez.");
        }
    }
}
