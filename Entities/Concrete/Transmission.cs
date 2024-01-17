using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Transmission : Entity<int>
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public Transmission()
        {
            Console.WriteLine("Transmission : Default Constructor Called !");
        }   // Default Constructor Implemented
        public Transmission(string name) // parameterized constructor Implemented
        {
            Name = name;
        }
    }
}
