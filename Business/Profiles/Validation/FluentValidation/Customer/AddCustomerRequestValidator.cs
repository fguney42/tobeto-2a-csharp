using Business.Requests.Customer;
using FluentValidation;

namespace Business.Profiles.Validation.FluentValidation.Customer
{
    public class AddCustomerRequestValidator : AbstractValidator<AddCustomerRequest>
    {
        public AddCustomerRequestValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            // Add any additional rules specific to Customer
        }
    }
}
