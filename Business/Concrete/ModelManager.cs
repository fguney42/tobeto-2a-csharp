using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        private readonly IModelDal _modelDal;
        private readonly ModelBusinessRules _modelBusinessRules;
        private readonly IMapper _mapper;
        public ModelManager(IModelDal modelDal, ModelBusinessRules modelBusinessRules, IMapper mapper)
        {
            _modelDal = modelDal;
            _modelBusinessRules = modelBusinessRules;
            _mapper = mapper;
        }
        public AddModelResponse Add(AddModelRequest request)
        {
            _modelBusinessRules.CheckIfModelNameLongerThanTwo(request.Name);
            _modelBusinessRules.CheckIfDailyPriceGreaterThanZero(request.DailyPrice);

            Model modelToAdd = _mapper.Map<Model>(request);
            _modelDal.Add(modelToAdd);

            AddModelResponse response = _mapper.Map<AddModelResponse>(modelToAdd);

            return response;
        }

        public GetModelListResponse GetList(GetModelListRequest request)
        {
            IList<Model> modelList = _modelDal.GetList();

            GetModelListResponse response = _mapper.Map<GetModelListResponse>(modelList);

            return response;
        }

        public GetModelListResponse GetListByBrand(GetModelListRequestByBrand request)
        {
            IList<Model> modelList = _modelDal.GetListByBrand(request.BrandId);

            GetModelListResponse response = _mapper.Map<GetModelListResponse>(modelList);

            return response;
        }

        public GetModelListResponse GetListByFuel(GetModelListRequestByFuel request)
        {
            IList<Model> modelList = _modelDal.GetListByFuel(request.FuelId);

            GetModelListResponse response = _mapper.Map<GetModelListResponse>(modelList);

            return response;
        }

        public GetModelListResponse GetListByTransmission(GetModelListRequestByTransmission request)
        {
            IList<Model> modelList = _modelDal.GetListByTransmission(request.TransmissionId);

            GetModelListResponse response = _mapper.Map<GetModelListResponse>(modelList);

            return response;
        }
    }
}