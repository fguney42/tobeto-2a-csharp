using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Fuel : Entity<int>
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public Fuel()
        {
            Console.WriteLine("Fuel : Default Constructor Called !");
        }   // Default Constructor Implemented
        public Fuel(string name) // parameterized constructor Implemented
        {
            Name = name;
        }
    }
}
