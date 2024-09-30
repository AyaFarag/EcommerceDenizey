using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using FluentValidation;



namespace Ecommerce.Application.Behaviors.Validation
{
    public class CategoryValidator : AbstractValidator<DTOCategory>
    {
        public CategoryValidator()
        {

            RuleFor(c => c.Name).NotNull().WithMessage("Please insert category !")
                .Length(2, 50).WithMessage("Min chars is 2 and max is 50");
                
        }
    }
}
