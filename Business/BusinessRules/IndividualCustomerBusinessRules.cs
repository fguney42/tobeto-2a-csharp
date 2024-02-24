// IndividualCustomerBusinessRules
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class IndividualCustomerBusinessRules
    {
        private readonly IIndividualCustomerDal _individualCustomerDal;

        public IndividualCustomerBusinessRules(IIndividualCustomerDal individualCustomerDal)
        {
            _individualCustomerDal = individualCustomerDal;
        }

        public void CheckIfIndividualCustomerExists(int individualCustomerId)
        {
            IndividualCustomer? individualCustomer = _individualCustomerDal.Get(ic => ic.Id == individualCustomerId);
            if (individualCustomer == null)
                throw new NotFoundException("IndividualCustomer not found.");
        }
    }
}
