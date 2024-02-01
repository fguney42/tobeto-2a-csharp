using Business.Requests.Car;
using Business.Responses.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        public AddCarResponse Add(AddCarRequest request);
        public GetCarListResponse GetList(GetCarListRequest carRequest);
    }
}
