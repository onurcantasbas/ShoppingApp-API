using FluentValidation;
using ShoppingApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Service.Validations
{
    public class ProductDTOValidator : AbstractValidator<ProductDTO>
    {
        public ProductDTOValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} is required")
                                .NotEmpty().WithMessage("{PropertyName} is required")
                                .MinimumLength(2)
                                .MaximumLength(50);
            RuleFor(x => x.Price).InclusiveBetween(1, 10000).WithMessage("{PropertyName} must be beetween 1-10000");
        }
    }
}
