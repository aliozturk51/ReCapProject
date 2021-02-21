﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        //Doğrulama kuralları constructor içine yazılır.
        public BrandValidator()
        {
            RuleFor(b=>b.BrandName).MinimumLength(3);
        }
    }
}