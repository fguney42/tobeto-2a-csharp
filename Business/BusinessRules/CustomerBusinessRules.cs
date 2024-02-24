using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class CustomerBusinessRules
    {
        private readonly ICustomerDal _customerDal;

        public CustomerBusinessRules(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void CheckIfCustomerExists(int customerId)
        {
            Customer? customer = _customerDal.Get(c => c.Id == customerId);
            if (customer == null)
                throw new NotFoundException("Customer not found.");
        }

    }
}
