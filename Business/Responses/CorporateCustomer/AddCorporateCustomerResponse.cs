// AddCorporateCustomerResponse.cs
namespace Business.Responses.CorporateCustomer
{
    public class AddCorporateCustomerResponse
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }

        // You can include any additional properties that you want to return in the response
    }
}
