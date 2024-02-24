namespace Business.Responses.Customer
{
    public class AddCustomerResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // You can include any additional properties that you want to return in the response
    }
}
