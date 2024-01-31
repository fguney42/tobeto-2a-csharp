using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.Customer;
using Business.Profiles.Validation.FluentValidation.Model;
using Business.Requests.Brand;
using Business.Responses.Brand;
using Business.Responses.Customer;
using Business.Responses.Model;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly CustomerBusinessRules _customerBusinessRules;
        private readonly IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal, CustomerBusinessRules customerBusinessRules, IMapper mapper)
        {
            _customerDal = customerDal;
            _customerBusinessRules = customerBusinessRules;
            _mapper = mapper;
        }

        public AddCustomerResponse Add(AddBrandRequest request)
        {
            ValidationTool.Validate(new AddCustomerRequestValidator(), request);
       
            _customerBusinessRules.CheckIfModelNameExists(request.Name);
         
            var modelToAdd = _mapper.Map<Customer>(request);

          
            Customer addedModel = _customerDal.Add(modelToAdd);

           
            var response = _mapper.Map<AddCustomerResponse>(addedModel);
            return response;
        }

        public AddCustomerResponse Delete(AddBrandRequest request)
        {
            throw new NotImplementedException();
        }

        public AddCustomerResponse Get(AddBrandRequest request)
        {
            throw new NotImplementedException();
        }

        public AddCustomerResponse GetList(GetBrandListRequest request)
        {
            throw new NotImplementedException();
        }

        public AddCustomerResponse Update(AddBrandRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
