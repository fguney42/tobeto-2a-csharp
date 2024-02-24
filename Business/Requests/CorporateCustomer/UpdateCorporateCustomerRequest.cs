namespace Business.Requests.CorporateCustomer
{
    public class UpdateCorporateCustomerRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
