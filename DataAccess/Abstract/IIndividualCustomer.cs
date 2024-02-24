using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IIndividualCustomerDal : IEntityRepository<IndividualCustomer, int>
    {
        // Additional methods specific to IndividualCustomer data access can be added here
    }
}
