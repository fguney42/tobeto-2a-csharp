using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class FuelBusinessRules
    {
        private readonly IFuelDal _fuelDal;

        public FuelBusinessRules(IFuelDal fuelDal) 
        {
            _fuelDal = fuelDal;
        }

        public void CheckIfFuelNameNotExists(string fuelName)
        {
            bool isFuelExists = _fuelDal.GetList().Any(b => b.Name == fuelName);

            if (isFuelExists)
                throw new BusinessException("Fuel already exists.");
        }
    }
}