using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validations.FluentValidation
{
    public class FvCarValidator:AbstractValidator<Car>
    {
        public FvCarValidator()
        {
            RuleFor(x=>x.ModelYear).NotEmpty().WithMessage("Evet");
            RuleFor(x => x.ColorId).NotEmpty().GreaterThan(5);
            RuleFor(x => x.BrandId).NotEmpty().WithMessage("Evet");
            RuleFor(x => x.BrandId).NotEmpty().WithMessage("selam");
            RuleFor(x => x.BrandId).NotEmpty().WithMessage("selam25");
        }
    }
}
