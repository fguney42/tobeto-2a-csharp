using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Business.Abstract;
using Business.Responses.Brand;
using Business.Responses.Fuel;
using Business.Requests.Fuel;
namespace Business.Concrete
{
    public class FuelManager : IFuelService
    {
        private readonly IFuelDal _fuelDal;
        private readonly FuelBusinessRules _fuelBusinessRules;
        private readonly IMapper _mapper;
        public FuelManager(IFuelDal fuelDal, FuelBusinessRules fuelBusinessRules, IMapper mapper)
        {
            _fuelDal = fuelDal;
            _fuelBusinessRules = fuelBusinessRules;
            _mapper = mapper;
        }
        public AddFuelResponse Add(AddFuelRequest request)
        {
            try
            {
                _fuelBusinessRules.CheckIfFuelNameNotExists(request.Name);
                _fuelBusinessRules.IsNullOrWhiteSpace(request.Name);
            }
            catch (Exception nameException)
            {
                Console.WriteLine("Error : " + nameException.Message); // Exception Handling
            }
            Fuel fuelToAdd = _mapper.Map<Fuel>(request);
            _fuelDal.Add(fuelToAdd);

            AddFuelResponse response = _mapper.Map<AddFuelResponse>(fuelToAdd);
            return response;
        }



        public IList<Fuel> GetList()
        {
            IList<Fuel> fuelList = _fuelDal.GetList();
            return fuelList;
        }
    }
}