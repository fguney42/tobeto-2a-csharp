using Business.Dtos.User;
using System;
namespace Business.Dtos.IndividualCustomer
{
    public class IndividualCustomerListItemDto
    {
        public int Id { get; set; }
        public UserListItemDto User { get; set; }
        public string NationalIdentity { get; set; }
    }
}