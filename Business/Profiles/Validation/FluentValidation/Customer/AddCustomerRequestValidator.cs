using Business.Profiles.Validation.FluentValidation.Model;
using Business.Requests;
using Business.Requests.Customer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.Customer
{
    public class AddCustomerRequestValidator : AbstractValidator<AddIndividualCustomerRequest>
    {


        public AddCustomerRequestValidator()
        {
        }
    }
}
