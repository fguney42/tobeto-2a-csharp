using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests
{
    public class AddCorporateCustomerRequest
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}