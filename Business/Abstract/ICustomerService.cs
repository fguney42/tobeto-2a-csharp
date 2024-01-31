using Business.Requests.Brand;
using Business.Responses.Brand;
using Business.Responses.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public AddCustomerResponse Add(AddBrandRequest request);
        public AddCustomerResponse Update(AddBrandRequest request);
        public AddCustomerResponse Delete(AddBrandRequest request);
        public AddCustomerResponse Get(AddBrandRequest request);
        public AddCustomerResponse GetList(GetBrandListRequest request);
    }
}
