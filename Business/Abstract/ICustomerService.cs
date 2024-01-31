using Business.Requests.Brand;
using Business.Responses.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public AddBrandResponse Add(AddBrandRequest request);
        public AddBrandResponse Update(AddBrandRequest request);
        public AddBrandResponse Delete(AddBrandRequest request);
        public AddBrandResponse Get(AddBrandRequest request);
        public GetBrandListResponse GetList(GetBrandListRequest request);
    }
}
