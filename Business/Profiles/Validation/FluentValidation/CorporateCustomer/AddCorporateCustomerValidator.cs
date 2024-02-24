using Business.Requests.CorporateCustomer;
using FluentValidation;

namespace Business.Profiles.Validation.FluentValidation.Customer
{
    public class AddCorporateCustomerRequestValidator : AbstractValidator<AddCorporateCustomerRequest>
    {
        public AddCorporateCustomerRequestValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            // Add any additional rules specific to CorporateCustomer
        }
    }
}
