using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).MaximumLength(5).WithMessage("Lütfen 5 KaRAKTERDEN KÜÇÜK Olsun");
            RuleFor(x => x.LastName).MaximumLength(5).WithMessage("5 KaRAKTERDEN KÜÇÜK OLSUN");
        }
    }
}
