using Business.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Customer
{
    public class CustomerListItemDto
    {
        public int Id { get; set; }
        public UserListItemDto User { get; set; }
    }
}
