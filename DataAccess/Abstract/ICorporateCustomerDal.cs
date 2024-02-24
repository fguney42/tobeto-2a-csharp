using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICorporateCustomerDal : IEntityRepository<CorporateCustomer, int>
    {
        // Additional methods specific to CorporateCustomer data access can be added here
    }
}
