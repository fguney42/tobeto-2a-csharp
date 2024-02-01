using Business.Requests;
using Business.Requests.CorporateCustomer;
using Business.Requests.Customer;
using Business.Responses.IndividualCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIndividualCustomerService
    {
        GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request);

        GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request);

        AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request);

        UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request);

        DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request);
    }
}
