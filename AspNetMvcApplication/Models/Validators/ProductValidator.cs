using FluentValidation;

namespace AspNetMvcApplication.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email Boş Olamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Email Giriniz");
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Name 100 den fazla olamaz");

        }
    }
}
