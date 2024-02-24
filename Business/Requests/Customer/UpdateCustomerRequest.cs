namespace Business.Requests.Customer
{
    public class UpdateCustomerRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Assuming UserId is required for updating a customer
        public string AdditionalCustomerProperty { get; set; } // Add any other properties needed
    }
}
