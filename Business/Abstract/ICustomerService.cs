using Business.Requests.Customer;
using Business.Responses.Customer;

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
