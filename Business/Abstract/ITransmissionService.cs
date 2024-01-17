using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Requests.Transmission;
using Entities.Concrete;
using Business.Responses.Transmission;


namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public AddTransmissionResponse Add(AddTransmissionRequest request);

        public IList<Transmission> getList();
    }
}
