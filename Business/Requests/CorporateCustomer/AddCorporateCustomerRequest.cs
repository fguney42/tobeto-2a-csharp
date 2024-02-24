namespace Business.Requests.CorporateCustomer
{
    public class AddCorporateCustomerRequest
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
