using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer, int>
    {
        // Custom operations specific to Customer if needed
    }
}
