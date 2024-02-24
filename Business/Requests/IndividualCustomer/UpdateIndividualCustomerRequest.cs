// UpdateIndividualCustomerRequest
namespace Business.Requests.IndividualCustomer
{
    public class UpdateIndividualCustomerRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Assuming UserId is required for updating an individual customer
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
    }
}
