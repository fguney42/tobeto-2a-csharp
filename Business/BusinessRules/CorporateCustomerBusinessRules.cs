using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class CorporateCustomerBusinessRules
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;

        public CorporateCustomerBusinessRules(ICorporateCustomerDal corporateCustomerDal)
        {
            _corporateCustomerDal = corporateCustomerDal;
        }

        public void CheckIfCorporateCustomerExists(int corporateCustomerId)
        {
            CorporateCustomer? corporateCustomer = _corporateCustomerDal.Get(cc => cc.Id == corporateCustomerId);
            if (corporateCustomer == null)
                throw new NotFoundException("CorporateCustomer not found.");
        }
    }
}
