using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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

        public AddBrandResponse Add(AddBrandRequest request)
        {
            throw new NotImplementedException();
        }

        public AddBrandResponse Delete(AddBrandRequest request)
        {
            throw new NotImplementedException();
        }

        public AddBrandResponse Get(AddBrandRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBrandListResponse GetList(GetBrandListRequest request)
        {
            throw new NotImplementedException();
        }

        public AddBrandResponse Update(AddBrandRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
