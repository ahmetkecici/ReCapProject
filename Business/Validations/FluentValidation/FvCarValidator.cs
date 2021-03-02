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
           
        }
    }
}
