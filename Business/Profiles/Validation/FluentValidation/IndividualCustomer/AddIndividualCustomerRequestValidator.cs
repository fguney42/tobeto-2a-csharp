// AddIndividualCustomerRequestValidator
using Business.Requests.IndividualCustomer;
using FluentValidation;

namespace Business.Profiles.Validation.FluentValidation.Customer
{
    public class AddIndividualCustomerRequestValidator : AbstractValidator<AddIndividualCustomerRequest>
    {
        public AddIndividualCustomerRequestValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            // Add any additional rules specific to IndividualCustomer
        }
    }
}
