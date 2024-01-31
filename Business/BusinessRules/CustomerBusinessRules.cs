using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CustomerBusinessRules
    {
        ICustomerDal _customerDal;

        public CustomerBusinessRules(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void CheckIfModelNameExists(string firstName)
        {
            bool isCustomerNameExists = _customerDal.Get
                (m => m.FirstName == firstName) != null;
            if (isCustomerNameExists)
                throw new BusinessException("Customer name already exists.");
        }
        public void CheckIfCustomerExists(Customer customer)
        {
            if (customer is null)
                throw new NotFoundException("Customer not found.");
        }
    }
}
