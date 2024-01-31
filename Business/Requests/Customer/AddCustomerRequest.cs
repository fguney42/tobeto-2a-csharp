using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Customer
{
    public class AddCustomerRequest {


        public string Name { get; set; }

    public AddCustomerRequest(string name)
    {
        Name = name;
    }
}
}
