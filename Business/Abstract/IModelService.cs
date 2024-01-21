using Business.Requests.Model;
using Business.Responses.Model;

namespace Business.Abstract
{
    public interface IModelService
    {
        // Listeleme Özellikleri
        // 1. Brand'e göre listeleme işlemi yapılabilmelidir.
        // 2. Fuel'e göre listeleme işlemi yapılabilmelidir.
        // 3. Transmission'e göre listeleme işlemi yapılabilmelidir.
        public AddModelResponse Add(AddModelRequest request);
        public GetModelListResponse GetList(GetModelListRequest request);

        public GetModelListResponse GetListByBrand(GetModelListRequestByBrand request);
        public GetModelListResponse GetListByFuel(GetModelListRequestByFuel request);
        public GetModelListResponse GetListByTransmission(GetModelListRequestByTransmission request);
    }
}