using Business.Dtos.Customer;
using System.Collections.Generic;

namespace Business.Responses.Customer
{
    public class GetCustomerListResponse
    {
        public ICollection<CustomerListItemDto> Items { get; set; }
    }
}
