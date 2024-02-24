// AddIndividualCustomerRequest
namespace Business.Requests.IndividualCustomer
{
    public class AddIndividualCustomerRequest
    {
        public int UserId { get; set; } // Assuming UserId is required for creating an individual customer
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
    }
}
