using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class CustomersBusinessRules
    {
        private readonly ICustomerDal _customersDal;

        public CustomersBusinessRules(ICustomerDal customersDal)
        {
            _customersDal = customersDal;
        }

        public void CheckIfCustomersInfoValid(string customersInfo)
        {
          
            if (string.IsNullOrWhiteSpace(customersInfo))
            {
                throw new BusinessException("Customer info cannot be empty.");
            }
        }

        public Customers FindCustomersId(int id)
        {
            Customers customers = _customersDal.GetList().SingleOrDefault(c => c.Id == id);
            return customers;
        }

        public void CheckIfCustomersExists(Customers? customers)
        {
            if (customers is null)
            {
                throw new NotFoundException("Customer not found.");
            }
        }
    }
}
