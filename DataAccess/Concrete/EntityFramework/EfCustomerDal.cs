using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public Customer Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(Customer entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Customer? Get(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetList(Func<Customer, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
