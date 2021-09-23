using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Yu_Gi_Oh_Card.Domain.Entities;

namespace Yu_Gi_Oh_Card.Service.Validators
{
    public class CardsValidator : AbstractValidator<Cards>
    {
        public CardsValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please enter the name.")
                .NotNull().WithMessage("Please enter the name.");            
        }
    }
}
