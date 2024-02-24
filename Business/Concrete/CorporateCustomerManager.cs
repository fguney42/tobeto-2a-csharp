// CorporateCustomerManager
using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.Customer;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CorporateCustomerManager : ICorporateCustomerService
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;
        private readonly CorporateCustomerBusinessRules _corporateCustomerBusinessRules;
        private readonly IMapper _mapper;

        public CorporateCustomerManager(ICorporateCustomerDal corporateCustomerDal, CorporateCustomerBusinessRules corporateCustomerBusinessRules, IMapper mapper)
        {
            _corporateCustomerDal = corporateCustomerDal;
            _corporateCustomerBusinessRules = corporateCustomerBusinessRules;
            _mapper = mapper;
        }

        public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request)
        {
            // Fluent validation
            ValidationTool.Validate(new AddCorporateCustomerRequestValidator(), request);

            // Business rules
            // Add additional business rules as needed

            // Mapping
            var corporateCustomerToAdd = _mapper.Map<CorporateCustomer>(request);

            // Data operations
            CorporateCustomer addedCorporateCustomer = _corporateCustomerDal.Add(corporateCustomerToAdd);

            // Mapping & response
            var response = _mapper.Map<AddCorporateCustomerResponse>(addedCorporateCustomer);
            return response;
        }

        public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request)
        {
            CorporateCustomer? corporateCustomerToDelete = _corporateCustomerDal.Get(predicate: customer => customer.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corporateCustomerToDelete.Id);

            CorporateCustomer deletedCorporateCustomer = _corporateCustomerDal.Delete(corporateCustomerToDelete);

            var response = _mapper.Map<DeleteCorporateCustomerResponse>(deletedCorporateCustomer);
            return response;
        }

        public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request)
        {
            CorporateCustomer? corporateCustomer = _corporateCustomerDal.Get(predicate: customer => customer.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corporateCustomer.Id);

            var response = _mapper.Map<GetCorporateCustomerByIdResponse>(corporateCustomer);
            return response;
        }

        public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request)
        {
            IList<CorporateCustomer> corporateCustomerList = _corporateCustomerDal.GetList().ToList();

            var response = _mapper.Map<GetCorporateCustomerListResponse>(corporateCustomerList);
            return response;
        }

        public UpdateCorporateCustomerResponse Update(UpdateCorporateCustomerRequest request)
        {
            CorporateCustomer? corporateCustomerToUpdate = _corporateCustomerDal.Get(predicate: customer => customer.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corporateCustomerToUpdate.Id);

            corporateCustomerToUpdate = _mapper.Map(request, corporateCustomerToUpdate);
            CorporateCustomer updatedCorporateCustomer = _corporateCustomerDal.Update(corporateCustomerToUpdate);

            var response = _mapper.Map<UpdateCorporateCustomerResponse>(updatedCorporateCustomer);
            return response;
        }
    }
}
