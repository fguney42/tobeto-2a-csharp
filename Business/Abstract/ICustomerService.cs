using Business.Requests;
using Business.Requests.Brand;
using Business.Requests.Customer;
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
        GetCustomerListResponse GetList(GetCustomerListRequest request);

        GetCustomerByIdResponse GetById(GetCustomerByIdRequest request);

        AddCustomerResponse Add(AddCustomerRequest request);

        UpdateCustomerResponse Update(UpdateCustomerRequest request);

        DeleteCustomerResponse Delete(DeleteCustomerRequest request);
    }
}
