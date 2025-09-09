using ETicaretAPI.Application.Commands.Request.ProductRequest;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.ProductValidators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Product name can not be null")
                .Length(2, 150)
                .WithMessage("Product name's length mush be between 2 and 150 character");

            RuleFor(x => x.Price)
                .NotEmpty()
                .NotNull()
                .WithMessage("Price can not be null")
                .GreaterThanOrEqualTo(0)
                .WithMessage("Price can not be less than 0");

            RuleFor(x => x.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("Stock can not be null")
                .GreaterThanOrEqualTo(0)
                .WithMessage("Stock can not be less than 0");
        }
    }
}
