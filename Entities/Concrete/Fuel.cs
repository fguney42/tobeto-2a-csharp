using Core.Entities;

namespace Entities.Concrete;

public class Fuel : Entity<int>
{
    public string Name { get; set; }
    public ICollection<Model> Models { get; set; } = new List<Model>();

    public Fuel()
    {
    }

    public Fuel(string name)
    {
        Name = name;
    }
}
