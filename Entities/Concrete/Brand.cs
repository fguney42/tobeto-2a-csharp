using Core.Entities;

namespace Entities.Concrete;

public class Brand : Entity<int>
{
    public string Name { get; set; }
    public string LogoUrl { set; get; }
    public bool Premium { set; get; }
    public double Rating { set; get; }
    public ICollection<Model> Models { get; set; } = new List<Model>();

    public Brand()
    {
    }

    public Brand(string name, string logoUrl,bool premium, double rating)
    {

        Name = name;
        LogoUrl = logoUrl;
        Premium = premium;
        Rating = rating;
    }
}
