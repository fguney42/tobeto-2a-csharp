using Business.Dtos.User;

namespace Business.Dtos.Customer
{
    public class CustomerListItemDto
    {
        public int Id { get; set; }
        public UserListItemDto User { get; set; }
    }
}
