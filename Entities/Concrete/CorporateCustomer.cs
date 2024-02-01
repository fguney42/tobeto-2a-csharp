using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CorporateCustomer : Customer 
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }   
    }
}
