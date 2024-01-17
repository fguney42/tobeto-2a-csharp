using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Transmission
{
    public class AddTransmissionResponse
    {

        public int Id { set; get; }
        public string Name { set; get; }
        public DateTime CreatedAt { set; get; }
        public AddTransmissionResponse(int id, string name, DateTime createdAt)
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
        }


    }
}
