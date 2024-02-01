using Business.Requests.Transmission;
using Business.Responses.Transmission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransmissionService
    {

         AddTransmissionResponse Add(AddTransmissionRequest request);
         GetTransmissionListResponse GetList(GetTransmissionListRequest request);

    }
}
