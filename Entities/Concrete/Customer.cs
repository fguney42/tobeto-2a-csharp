using Core.Entities;
using Entities.Concrete;

public class Customer : Entity<int>
{
    // Additional properties specific to Customer
    public int UserId { get; set; }

    public User User { get; set; }
}
