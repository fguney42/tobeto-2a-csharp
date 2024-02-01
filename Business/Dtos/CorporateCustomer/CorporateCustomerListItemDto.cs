using Business.Dtos.User;

namespace Business.Dtos.CorporateCustomer
{
    public class CorporateCustomerListItemDto
    {
        public int Id { get; set; }
        public UserListItemDto User { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}