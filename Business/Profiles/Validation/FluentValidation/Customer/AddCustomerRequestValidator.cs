using Business.Profiles.Validation.FluentValidation.Model;
using Business.Requests.Customer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.Customer
{
    public class AddCustomerRequestValidator : AbstractValidator<AddCustomerRequest>
    {


        public AddCustomerRequestValidator()
        {

            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);

          
        }
    }
}
