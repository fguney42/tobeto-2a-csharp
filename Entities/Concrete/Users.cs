using Core.Entities;

namespace Entities.Concrete
{ 
    public class Users : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Users()
        {
           Customers =  new List<Customers>();
        }
        public Users(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public ICollection<Customers> Customers;
        public IndividualCustomer? IndividualCustomer { get; set; }
        public CorporateCustomer? CorporateCustomer { get; set; }
    }
}