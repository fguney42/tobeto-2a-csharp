using Business.Dtos.IndividualCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.IndividualCustomer
{
    public class GetIndividualCustomerListResponse
    {
        public ICollection<IndividualCustomerListItemDto> Items { get; set; }
    }
}
