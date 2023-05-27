using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name alanı boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karakter içermelidir.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adı en fazla 100 karakter içerebilir.");

            RuleFor(x => x.ImageFullUrl).NotNull().WithMessage("Image Full Url alanı boş geçilemez.");
            RuleFor(x => x.ImageShortUrl).NotNull().WithMessage("Image Short Url alanı boş geçilemez.");
            RuleFor(x => x.ProjectUrl).NotNull().WithMessage("Project url alanı boş geçilemez.");
        
        }
    }
}
