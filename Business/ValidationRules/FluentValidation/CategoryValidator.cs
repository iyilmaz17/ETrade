using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator :AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            // Category 1
            RuleFor(c => c.CategoryName1).NotEmpty();
            RuleFor(c => c.CategoryName1).MinimumLength(5);
            RuleFor(c => c.CategoryName1).MaximumLength(25);
            // Category 2
            RuleFor(c => c.CategoryName2).NotEmpty();
            RuleFor(c => c.CategoryName2).MinimumLength(5);
            RuleFor(c => c.CategoryName2).MaximumLength(25);
            // Category 3
            RuleFor(c => c.CategoryName3).NotEmpty();
            RuleFor(c => c.CategoryName3).MinimumLength(5);
            RuleFor(c => c.CategoryName3).MaximumLength(25);
            // Category 4
            //RuleFor(c => c.CategoryName4).NotEmpty();
            RuleFor(c => c.CategoryName4).MinimumLength(5);
            RuleFor(c => c.CategoryName4).MaximumLength(25);

        }
    }
}
