// IndividualCustomerManager
using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.Customer;
using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class IndividualCustomerManager : IIndividualCustomerService
    {
        private readonly IIndividualCustomerDal _individualCustomerDal;
        private readonly IndividualCustomerBusinessRules _individualCustomerBusinessRules;
        private readonly IMapper _mapper;

        public IndividualCustomerManager(IIndividualCustomerDal individualCustomerDal, IndividualCustomerBusinessRules individualCustomerBusinessRules, IMapper mapper)
        {
            _individualCustomerDal = individualCustomerDal;
            _individualCustomerBusinessRules = individualCustomerBusinessRules;
            _mapper = mapper;
        }

        public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request)
        {
            // Fluent validation
            ValidationTool.Validate(new AddIndividualCustomerRequestValidator(), request);

            // Business rules
            // Add additional business rules as needed

            // Mapping
            var individualCustomerToAdd = _mapper.Map<IndividualCustomer>(request);

            // Data operations
            IndividualCustomer addedIndividualCustomer = _individualCustomerDal.Add(individualCustomerToAdd);

            // Mapping & response
            var response = _mapper.Map<AddIndividualCustomerResponse>(addedIndividualCustomer);
            return response;
        }

        public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request)
        {
            IndividualCustomer? individualCustomerToDelete = _individualCustomerDal.Get(predicate: customer => customer.Id == request.Id);
            _individualCustomerBusinessRules.CheckIfIndividualCustomerExists(individualCustomerToDelete.Id);

            IndividualCustomer deletedIndividualCustomer = _individualCustomerDal.Delete(individualCustomerToDelete);

            var response = _mapper.Map<DeleteIndividualCustomerResponse>(deletedIndividualCustomer);
            return response;
        }

        public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request)
        {
            IndividualCustomer? individualCustomer = _individualCustomerDal.Get(predicate: customer => customer.Id == request.Id);
            _individualCustomerBusinessRules.CheckIfIndividualCustomerExists(individualCustomer.Id);

            var response = _mapper.Map<GetIndividualCustomerByIdResponse>(individualCustomer);
            return response;
        }

        public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request)
        {
            IList<IndividualCustomer> individualCustomerList = _individualCustomerDal.GetList().ToList();

            var response = _mapper.Map<GetIndividualCustomerListResponse>(individualCustomerList);
            return response;
        }

        public UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request)
        {
            IndividualCustomer? individualCustomerToUpdate = _individualCustomerDal.Get(predicate: customer => customer.Id == request.Id);
            _individualCustomerBusinessRules.CheckIfIndividualCustomerExists(individualCustomerToUpdate.Id);

            individualCustomerToUpdate = _mapper.Map(request, individualCustomerToUpdate);
            IndividualCustomer updatedIndividualCustomer = _individualCustomerDal.Update(individualCustomerToUpdate);

            var response = _mapper.Map<UpdateIndividualCustomerResponse>(updatedIndividualCustomer);
            return response;
        }
    }
}
