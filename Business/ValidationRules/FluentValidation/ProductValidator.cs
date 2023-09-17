using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
           RuleFor(p => p.ProductName).MinimumLength(5).WithMessage("Ürün Adı en az 5 karakter");

            // UnitPrice
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Ürün fiyatı 0 olamaz");
            RuleFor(p => p.UnitPrice).NotEmpty();
        }
    }
}