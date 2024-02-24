// ICorporateCustomerService.cs
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;

namespace Business.Abstract
{
    public interface ICorporateCustomerService
    {
        GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request);

        GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request);

        AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request);

        UpdateCorporateCustomerResponse Update(UpdateCorporateCustomerRequest request);

        DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request);
    }
}
