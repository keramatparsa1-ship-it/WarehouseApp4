using FluentValidation;
using WarehouseApp.Application.Features.Products.Commands.CreateProduct;


namespace WarehouseApp.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("نام محصول اجباری است.")
            .MaximumLength(100).WithMessage("نام محصول نمی‌تواند بیش از ۱۰۰ کاراکتر باشد.");

        RuleFor(p => p.Price)
            .GreaterThan(0).WithMessage("قیمت باید بزرگتر از صفر باشد.");
    }
}
